// Diane Game Engine
// Copyleft (C) 2019-present Eric Ahnell
// Any questions should be directed to the author via email at: support@puttysoftware.com

namespace DianeSharp.Point;

public class Point6d(int nx, int ny, int nz, int nw, int nv, int nu)
{
    public int X { get; set; } = nx;
    public int Y { get; set; } = ny;
    public int Z { get; set; } = nz;
    public int W { get; set; } = nw;
    public int V { get; set; } = nv;
    public int U { get; set; } = nu;
}
