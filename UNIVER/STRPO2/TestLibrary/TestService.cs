using DBLibrary;
using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class TestService : BLINterfaces.IUTService
    {
        List<UserTypeModel> res = new List<UserTypeModel>();

        public TestService()
        {
            for (int i = 0; i < 22; i++)
            {
                res.Add(new UserTypeModel
                {
                    Name = $"Пользователь {i + 1}",
                    ID = i
                });
            }
        }


        public PagedResult<UserTypeModel> GetUTs(int id = -1)
        {

            var rr = new PagedResult<UserTypeModel>();
            List<UserTypeModel> tres = new List<UserTypeModel>();

            if (id == -1)
                tres = res;
            else
                foreach (var item in res)
                {
                    if (item.ID == id)
                    {
                        tres.Add(item);
                        break;
                    }
                }


            rr.Page = tres.ToArray();
            rr.PageCount = 1;
            return rr;

        }


        public PagedResult<UserTypeModel> GetPagedUTs(int page, int pagecount)
        {
            var rr = new PagedResult<UserTypeModel>();
            var ttx = res.Skip((page - 1) * pagecount).Take(pagecount).ToArray();
            rr.Page = ttx;
                rr.PageCount = res.Count() / pagecount + 1;
            return rr;
        }
    }
}
