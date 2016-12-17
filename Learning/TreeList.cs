using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class TreeList
    {
        public void Findpath(TreeNode Root, string name)
        {
            Console.WriteLine(Root.name);
            if (Root.Employees == null)
                return;
            for (int i = 0; i < Root.Employees.Count; i++)
            {
                Findpath(Root.Employees[i], name);
            }
        }
    }
}
