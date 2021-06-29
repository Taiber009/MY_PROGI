using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLINterfaces
{
    public interface IUTService
    {
        PagedResult<UserTypeModel> GetUTs(int id = -1);

        PagedResult<UserTypeModel> GetPagedUTs(int page, int pagecount);
    }
}
