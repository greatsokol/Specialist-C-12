
public class FindFiles
{
    public string Dir { get; set; }
    public string Ext { get; set; }

    public Action<object> Done { get; set; }
    public static Action<object> StaticDone { get; set; }

    public FindFiles(string dir, string ext)
    {
        Dir = dir;
        Ext = ext;
    }
    public void Find()
    {
        String[] set;
        if (Directory.Exists(Dir))
        {
            set = Directory.GetFiles(Dir, "*." + Ext, SearchOption.AllDirectories);
            Done?.Invoke(this);
            StaticDone?.Invoke(this);
        }
        else set = new string[] { "Directory not found!" };

    }
}
