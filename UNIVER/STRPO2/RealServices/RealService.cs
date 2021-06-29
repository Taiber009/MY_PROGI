using BLINterfaces;
using DBLibrary;
using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealServices
{
    public class RealService : BLINterfaces.IUTService
    {
        public PagedResult<UserTypeModel> GetUTs(int id = -1)
        {
            using (var c = new STRPO2Entities())
            {
                var rr = new PagedResult<UserTypeModel>();
                var tt = c.User_type; 
                int cc = tt.Count();

                List<UserTypeModel> res;
                res = id == -1 ?
                    tt.Select(UserType => new UserTypeModel
                    {
                        ID = UserType.ID,
                        Name = UserType.Name
                    }).ToList() :
                    (from userType in tt
                     where userType.ID == id
                     select new UserTypeModel
                     {
                         ID = userType.ID,
                         Name = userType.Name
                     }).ToList();
                rr.Page = res.ToArray();
                rr.PageCount = 1;
                return rr;
            }
        }

        public PagedResult<UserTypeModel> GetPagedUTs(int page, int pagecount)
        {
            using (var c = new STRPO2Entities())
            {
                var rr = new PagedResult<UserTypeModel>();
                var tt = (from o in c.User_type select o).OrderBy(o => o.ID);
                int cc = tt.Count();
                var ttx = tt.Skip((page - 1) * pagecount).Take(pagecount).ToArray();

                List<UserTypeModel> res = new List<UserTypeModel>();
                foreach (var item in ttx)
                {
                    res.Add(new UserTypeModel { ID = item.ID, Name = item.Name });
                }
                rr.Page = res.ToArray();
                var tc = tt.Count();
                if(tc % pagecount == 0)
                    rr.PageCount = tc / pagecount;
                else
                    rr.PageCount = tc / pagecount + 1;
                return rr;
            }
        }
    }
}
