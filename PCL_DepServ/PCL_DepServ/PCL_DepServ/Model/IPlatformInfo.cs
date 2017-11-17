using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL_DepServ.Model
{
    public interface IPlatformInfo
    {
        /// <summary>
        /// ask for model information
        /// </summary>
        /// <returns>the current model</returns>
        string GetModel();

        /// <summary>
        /// ask for version information
        /// </summary>
        /// <returns>the current version</returns>
        string GetVersion();
    }
}
