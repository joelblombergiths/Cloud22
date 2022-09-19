using System.Text;
//c:\temp\png.png

//Console.WriteLine("Enter Path to image:");
//string path = Console.ReadLine();

string path = @"c:\temp\bmp.png";
FileInfo file = new(path);

if (file.Exists)
{
    using FileStream fs = file.OpenRead();

    if(CheckIfPngFile(fs))
    {
        Console.WriteLine("Signature found, is PNG file");

        PrintPngMetaData(fs);

        if (!file.Extension.ToLower().Equals(".png")) Console.WriteLine("File Extension missmatch");
    }
    else if(CheckIfBmpFile(fs))
    {
        Console.WriteLine("Signature found, is BMP file");

        PrintBmpMetaData(fs);

        if (!file.Extension.ToLower().Equals(".bmp")) Console.WriteLine("File Extension missmatch");
    }
    else Console.WriteLine("Not a PNG or BMP file");
}
else
{
    Console.WriteLine("File not found");
}

bool CheckIfPngFile(FileStream fs)
{
    byte[] pngSignature = new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A };
    byte[] signature = new byte[8];

    fs.Seek(0, SeekOrigin.Begin);
    fs.Read(signature, 0, 8);

    return signature.SequenceEqual(pngSignature);
}

bool CheckIfBmpFile(FileStream fs)
{
    byte[] bmpSignature = new byte[] { 0x42, 0x4D };
    byte[] signature = new byte[2];

    fs.Seek(0, SeekOrigin.Begin);
    fs.Read(signature, 0, 2);

    return signature.SequenceEqual(bmpSignature);
}


void PrintPngMetaData(FileStream fs)
{
    const int CRC_LENGTH = 4;

    byte[] IHDR = new byte[] { 0x49, 0x48, 0x44, 0x52 };
    
    byte[] chunkLen = new byte[4];
    uint length;

    while (fs.Read(chunkLen, 0, 4) > 0)
    {
        if (BitConverter.IsLittleEndian)
        {
            Array.Reverse(chunkLen);
        }

        length = BitConverter.ToUInt32(chunkLen, 0);

        byte[] chunkType = new byte[4];
        fs.Read(chunkType, 0, 4);

        StringBuilder metaData = new();
        metaData.Append(chunkType.Select(c => (char)c).ToArray());
        Console.WriteLine($"Chunk type: {metaData}, Length: {length}");

        if (chunkType.SequenceEqual(IHDR))
        {
            byte[] widthBytes = new byte[4];
            byte[] heightBytes = new byte[4];

            int readBytes = fs.Read(widthBytes, 0, 4);
            readBytes += fs.Read(heightBytes, 0, 4);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(widthBytes);
                Array.Reverse(heightBytes);
            }

            int width = BitConverter.ToInt32(widthBytes, 0);
            int height = BitConverter.ToInt32(heightBytes, 0);

            Console.WriteLine($"Resolution: {width}x{height}");

            fs.Seek(length - readBytes, SeekOrigin.Current);
        }
        else
        {
            fs.Seek(length, SeekOrigin.Current); //Data
        }

        fs.Seek(CRC_LENGTH, SeekOrigin.Current); //CRC
    }
}

void PrintBmpMetaData(FileStream fs)
{
    const int RESOLUTION_OFFSET = 18;    

    fs.Seek(RESOLUTION_OFFSET, SeekOrigin.Begin);
    byte[] widthBytes = new byte[4];
    byte[] heightBytes = new byte[4];

    fs.Read(widthBytes, 0, 4);
    fs.Read(heightBytes, 0, 4);

    int width = BitConverter.ToInt32(widthBytes, 0);
    int height = BitConverter.ToInt32(heightBytes, 0);

    Console.WriteLine($"Resolution: {width}x{height}");
}
