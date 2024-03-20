[DllImport("user32.dll", CharSet = CharSet.Auto)]
private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

public static void Main()
{
    int result = MessageBox(IntPtr.Zero, "Hello, world!", "My Application", 0);
}
