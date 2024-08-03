using System.Text;

namespace Alg.solved;

public static class n71_Simplify_Path
{
    public static void Run()
    {
        foreach (var str in new[]
                 {
                     "/home/",
                     "/home//foo/",
                     "/home/user/Documents/../Pictures",
                     "/../",
                     "/.../a/../b/c/../d/./"
                 })
        {
            var res = SimplifyPath(str);
        }
    }

    private static string SimplifyPath(string path)
    {
        var st = new Stack<string>();
        var sb = new StringBuilder();

        foreach (var c in path)
        {
            if (c != '/')
            {
                sb.Append(c);

                continue;
            }

            if (sb.Length == 0)
            {
                continue;
            }

            Action(sb.ToString());

            sb.Clear();
        }

        if (sb.Length != 0)
        {
            Action(sb.ToString());
        }

        return $"/{string.Join('/', st.Reverse())}";

        void Action(string key)
        {
            switch (key)
            {
                case ".":
                    break;
                case "..":
                    if (st.Count != 0)
                    {
                        st.Pop();
                    }

                    break;
                default:
                    st.Push(key);
                    break;
            }
        }
    }
}