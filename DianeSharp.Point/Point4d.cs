// Diane Game Engine
// Copyleft (C) 2019-present Eric Ahnell
// Any questions should be directed to the author via email at: support@puttysoftware.com

namespace DianeSharp.Point;

public class Point4d(int nx, int ny, int nz, int nw)
{
    public int X { get; set; } = nx;
    public int Y { get; set; } = ny;
    public int Z { get; set; } = nz;
    public int W { get; set; } = nw;
}
