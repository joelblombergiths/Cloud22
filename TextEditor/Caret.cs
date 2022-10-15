using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace TextEditor
{
    public class Caret : NativeWindow
    {
        public Caret(Control owner)
            : base()
        {
            Parent = owner;
            AssignHandle(owner.Handle);
        }

        ~Caret()
        {
            if (!hBitmap.Equals(IntPtr.Zero))
                DeleteObject(hBitmap);
            DestroyCaretInternal();
            ReleaseHandle();
        }

        private bool DesignMode
        {
            get
            {
                ISite? site = Parent?.Site;
                return (site != null) && site.DesignMode;
            }
        }

        #region Private Instance Variables

        private readonly Control? Parent = null;

        private Size size = Size.Empty;
        private Point location = Point.Empty;

        private bool visible = true;

        private CaretStyle style = CaretStyle.Line;
        private Bitmap? bitmap = null;

        private IntPtr hBitmap = IntPtr.Zero;

        #endregion

        #region Properties

        public Size Size
        {
            get
            {
                if (size.IsEmpty)
                    return new Size(SystemInformation.CaretWidth, Parent.Font.Height);
                return size;
            }
            set
            {
                if (!Size.Equals(value))
                {
                    size = value;
                    OnSizeChanged(EventArgs.Empty);
                }
            }
        }

        public Point Location
        {
            get 
            {
                location = GetCaretPositionInternal();
                return location;
            }
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    OnLocationChanged(EventArgs.Empty);
                }
            }
        }

        public int Width
        {
            get { return Size.Width; }
        }

        public int Height
        {
            get { return Size.Height; }
        }

        public int Left
        {
            get { return Location.X; }
        }

        public int Top
        {
            get { return Location.Y; }
        }

        public bool Visible
        {
            get { return visible; }
            set
            {
                if (visible != value)
                {
                    visible = value;
                    OnVisibleChanged(EventArgs.Empty);
                }
            }
        }

        public CaretStyle Style
        {
            get { return style; }
            set
            {
                if (style != value)
                {
                    style = value;
                    OnStyleChanged(EventArgs.Empty);
                }
            }
        }

        public Bitmap? Bitmap
        {
            get { return bitmap; }
            set
            {
                if (bitmap != value)
                {
                    bitmap = value;
                    OnStyleChanged(EventArgs.Empty);
                }
            }
        }

        #endregion

        #region private methods

        private void OnSizeChanged(EventArgs eventArgs)
        {
            UpdateCaret();
        }

        private void OnLocationChanged(EventArgs eventArgs)
        {
            SetCaretPositionInternal();
        }

        private void OnVisibleChanged(EventArgs eventArgs)
        {
            if (visible)
                ShowCaretInternal();
            else
                HideCaretInternal();
        }

        private void OnStyleChanged(EventArgs eventArgs)
        {
            switch (Style)
            {
                case CaretStyle.Bitmap:
                    CreateHBitmap();
                    break; ;
                case CaretStyle.Block:
                    hBitmap = (IntPtr)1;
                    break;
                default:
                    hBitmap = IntPtr.Zero;
                    break;
            }
            UpdateCaret();
        }

        private void UpdateCaret()
        {
            DestroyCaretInternal();
            CreateCaretInternal();
            OnVisibleChanged(EventArgs.Empty);
        }

        private void CreateHBitmap()
        {
            if (!DesignMode)
            {
                if (hBitmap != IntPtr.Zero)
                    DeleteObject(hBitmap);
                hBitmap = Bitmap == null ? IntPtr.Zero : Bitmap.GetHbitmap();
            }
        }

        private void CreateCaretInternal()
        {
            if (!DesignMode)
                CreateCaret(Handle, hBitmap, Style == CaretStyle.Line ? 0 : Width, Height);
        }

        private void DestroyCaretInternal()
        {
            if (!DesignMode)
                DestroyCaret();
        }

        private void ShowCaretInternal()
        {
            if (!DesignMode)
                ShowCaret(Handle);
        }

        private void HideCaretInternal()
        {
            if (!DesignMode)
                HideCaret(Handle);
        }

        private void SetCaretPositionInternal()
        {
            if (!DesignMode)
                SetCaretPos(Left, Top);
        }

        private Point GetCaretPositionInternal()
        {
            Point p = Point.Empty;
            if (!DesignMode)
                GetCaretPos(ref p);
            return p;
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_SETFOCUS:
                    CreateCaretInternal();
                    SetCaretPositionInternal();
                    ShowCaretInternal();
                    break;

                case WM_KILLFOCUS:
                    DestroyCaretInternal();
                    break;
            }
        }

        public enum CaretStyle
        {
            Line, Block, Bitmap
        }

        #region NativeMethods

        /// <summary>
        /// The CreateCaret function creates a new shape for the system caret and assigns ownership of the caret to the specified window. The caret shape can be a line, a block, or a bitmap.
        /// </summary>
        /// <param name="hWnd">
        ///     [in] Handle to the window that owns the caret.
        /// </param>
        /// <param name="hBitmap">
        ///     [in] Handle to the bitmap that defines the caret shape. If this parameter is NULL, the caret is solid. If this parameter is (HBITMAP) 1, the caret is gray. If this parameter is a bitmap handle, the caret is the specified bitmap. The bitmap handle must have been created by the CreateBitmap, CreateDIBitmap, or LoadBitmap function. 
        ///     If hBitmap is a bitmap handle, CreateCaret ignores the nWidth and nHeight parameters; the bitmap defines its own width and height.
        ///</param>
        /// <param name="nWidth">
        ///     [in] Specifies the width of the caret in logical units. If this parameter is zero, the width is set to the system-defined window border width. If hBitmap is a bitmap handle, CreateCaret ignores this parameter.
        /// </param>
        /// <param name="nHeight">
        ///     [in] Specifies the height, in logical units, of the caret. If this parameter is zero, the height is set to the system-defined window border height. If hBitmap is a bitmap handle, CreateCaret ignores this parameter. 
        /// </param>
        /// <returns>
        ///     If the function succeeds, the return value is nonzero. 
        ///     If the function fails, the return value is zero. To get extended error information, call GetLastError.
        /// </returns>
        /// <remarks>
        ///     The nWidth and nHeight parameters specify the caret's width and height, in logical units; the exact width and height, in pixels, depend on the window's mapping mode. 
        ///     CreateCaret automatically destroys the previous caret shape, if any, regardless of the window that owns the caret. The caret is hidden until the application calls the ShowCaret function to make the caret visible. 
        ///     The system provides one caret per queue. A window should create a caret only when it has the keyboard focus or is active. The window should destroy the caret before losing the keyboard focus or becoming inactive. 
        ///     You can retrieve the width or height of the system's window border by using the GetSystemMetrics function, specifying the SM_CXBORDER and SM_CYBORDER values. Using the window border width or height guarantees that the caret will be visible on a high-resolution screen. 
        /// </remarks>
        [DllImport("user32", SetLastError = true)]
        private static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        /// <summary>
        /// The DestroyCaret function destroys the caret's current shape, frees the caret from the window, and removes the caret from the screen. 
        /// </summary>
        /// <returns>
        ///     If the function succeeds, the return value is nonzero.
        ///     If the function fails, the return value is zero. To get extended error information, call GetLastError. 
        /// </returns>
        /// <remarks>
        ///     DestroyCaret destroys the caret only if a window in the current task owns the caret. If a window that is not in the current task owns the caret, DestroyCaret does nothing and returns FALSE. 
        ///     The system provides one caret per queue. A window should create a caret only when it has the keyboard focus or is active. The window should destroy the caret before losing the keyboard focus or becoming inactive. 
        /// </remarks>
        [DllImport("user32", SetLastError = true)]
        private static extern bool DestroyCaret();

        /// <summary>
        /// The GetCaretBlinkTime function returns the time required to invert the caret's pixels. The user can set this value
        /// </summary>
        /// <returns>
        ///     If the function succeeds, the return value is the blink time, in milliseconds.
        ///     A return value of INFINITE indicates that the caret does not blink.
        ///     A return value is zero indicates that the function has failed. To get extended error information, call GetLastError.
        /// </returns>
        [DllImport("user32", SetLastError = true)]
        private static extern uint GetCaretBlinkTime();

        /// <summary>
        /// The GetCaretPos function copies the caret's position to the specified POINT structure. 
        /// </summary>
        /// <param name="lpPoint">
        ///     [out] Pointer to the POINT structure that is to receive the client coordinates of the caret. 
        /// </param>
        /// <returns>
        ///     If the function succeeds, the return value is nonzero. 
        ///     If the function fails, the return value is zero. To get extended error information, call GetLastError. 
        /// </returns>
        /// <remarks>
        ///     The caret position is always given in the client coordinates of the window that contains the caret. 
        /// </remarks>
        [DllImport("user32", SetLastError = true)]
        private static extern bool GetCaretPos(ref Point lpPoint);

        /// <summary>
        /// The HideCaret function removes the caret from the screen. Hiding a caret does not destroy its current shape or invalidate the insertion point. 
        /// </summary>
        /// <param name="hWnd">
        ///     [in] Handle to the window that owns the caret. If this parameter is NULL, HideCaret searches the current task for the window that owns the caret.
        /// </param>
        /// <returns>
        ///     If the function succeeds, the return value is nonzero.
        ///     If the function fails, the return value is zero. To get extended error information, call GetLastError. 
        /// </returns>
        /// <remarks>
        ///     HideCaret hides the caret only if the specified window owns the caret. If the specified window does not own the caret, HideCaret does nothing and returns FALSE. 
        ///     Hiding is cumulative. If your application calls HideCaret five times in a row, it must also call ShowCaret five times before the caret is displayed. 
        /// </remarks>
        [DllImport("user32", SetLastError = true)]
        private static extern bool HideCaret(IntPtr hWnd);

        /// <summary>
        /// The SetCaretBlinkTime function sets the caret blink time to the specified number of milliseconds. The blink time is the elapsed time, in milliseconds, required to invert the caret's pixels. 
        /// </summary>
        /// <param name="uMSeconds">
        ///     [in] Specifies the new blink time, in milliseconds. 
        /// </param>
        /// <returns>
        ///     If the function succeeds, the return value is nonzero.
        ///     If the function fails, the return value is zero. To get extended error information, call GetLastError. 
        /// </returns>
        /// <remarks>
        ///     The user can set the blink time using the Control Panel. Applications should respect the setting that the user has chosen. The SetCaretBlinkTime function should only be used by application that allow the user to set the blink time, such as a Control Panel applet.
        ///     If you change the blink time, subsequently activated applications will use the modified blink time, even if you restore the previous blink time when you lose the keyboard focus or become inactive. This is due to the multithreaded environment, where deactivation of your application is not synchronized with the activation of another application. This feature allows the system to activate another application even if the current application is not responding. 
        /// </remarks>
        [DllImport("user32", SetLastError = true)]
        private static extern bool SetCaretBlinkTime(uint uMSeconds);

        /// <summary>
        /// The SetCaretPos function moves the caret to the specified coordinates. If the window that owns the caret was created with the CS_OWNDC class style, then the specified coordinates are subject to the mapping mode of the device context associated with that window. 
        /// </summary>
        /// <param name="X">
        ///     [in] Specifies the new x-coordinate of the caret. 
        /// </param>
        /// <param name="Y">
        ///     [in] Specifies the new y-coordinate of the caret. 
        /// </param>
        /// <returns>
        ///     If the function succeeds, the return value is nonzero.
        ///     If the function fails, the return value is zero. To get extended error information, call GetLastError. 
        /// </returns>
        /// <remarks>
        ///     SetCaretPos moves the caret whether or not the caret is hidden. 
        ///     The system provides one caret per queue. A window should create a caret only when it has the keyboard focus or is active. The window should destroy the caret before losing the keyboard focus or becoming inactive. A window can set the caret position only if it owns the caret. 
        /// </remarks>
        [DllImport("user32", SetLastError = true)]
        private static extern bool SetCaretPos(int X, int Y);

        /// <summary>
        /// The ShowCaret function makes the caret visible on the screen at the caret's current position. When the caret becomes visible, it begins flashing automatically.
        /// </summary>
        /// <param name="hWnd">
        ///     [in] Handle to the window that owns the caret. If this parameter is NULL, ShowCaret searches the current task for the window that owns the caret. 
        /// </param>
        /// <returns>
        ///     If the function succeeds, the return value is nonzero.
        ///     If the function fails, the return value is zero. To get extended error information, call GetLastError. 
        /// </returns>
        /// <remarks>
        ///     ShowCaret shows the caret only if the specified window owns the caret, the caret has a shape, and the caret has not been hidden two or more times in a row. If one or more of these conditions is not met, ShowCaret does nothing and returns FALSE. 
        ///     Hiding is cumulative. If your application calls HideCaret five times in a row, it must also call ShowCaret five times before the caret reappears. 
        ///     The system provides one caret per queue. A window should create a caret only when it has the keyboard focus or is active. The window should destroy the caret before losing the keyboard focus or becoming inactive. 
        /// </remarks>
        [DllImport("user32", SetLastError = true)]
        private static extern bool ShowCaret(IntPtr hWnd);

        /// <summary>
        /// The DeleteObject function deletes a logical pen, brush, font, bitmap, region, or palette, freeing all system resources associated with the object. After the object is deleted, the specified handle is no longer valid.
        /// </summary>
        /// <param name="hObject">
        ///     [in] Handle to a logical pen, brush, font, bitmap, region, or palette.
        /// </param>
        /// <returns>
        ///     If the function succeeds, the return value is nonzero.
        ///     If the specified handle is not valid or is currently selected into a DC, the return value is zero.
        /// </returns>
        /// <remarks>
        ///     Do not delete a drawing object (pen or brush) while it is still selected into a DC.
        ///     When a pattern brush is deleted, the bitmap associated with the brush is not deleted. The bitmap must be deleted independently.
        /// </remarks>
        [DllImport("gdi32")]
        private static extern bool DeleteObject(IntPtr hObject);

        private const int WM_SETFOCUS = 0x7;
        private const int WM_KILLFOCUS = 0x8;

        #endregion

    }
}
