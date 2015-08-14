using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Common;
using Com.Ktbl.FontHP.Domain.ViewDomain;

namespace Com.Ktbl.FontHP.Map.Repository
{
    public interface IProvinceRepository
    {
        /// <summary>
        /// [20150813] add by Woody
        /// combo box province all
        /// </summary>
        /// <returns></returns>
        List<Province> ProvinceAll();
        /// <summary>
        /// [20150813] add by Woody
        /// combo box district 
        /// </summary>
        /// <returns></returns>
        List<District> DistrictAll();
        /// <summary>
        /// [20150813] add by Woody
        /// commbo box subdistrict 
        ///
        /// </summary>
        /// <returns></returns>
        List<SubDistrict> SubDistrictAll();
    }
    public class ProvinceRepository : NhRepository, IProvinceRepository
    {
        /// <summary>
        /// [20150813] add by Woody
        /// combo box province all
        /// </summary>
        /// <returns></returns>
        public List<Province> ProvinceAll(){
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                //var province = session.QueryOver<ProvinceDomain>().Select(x => new Province {id = x.ProvinceId, Name = x.ProvinceName  }).List<Province>();
                var province = session.QueryOver<ProvinceDomain>().List<ProvinceDomain>();
                return province.Select(x=>new Province{id=x.ProvinceId,Name = x.ProvinceName }).ToList<Province>()  as List<Province>;
            }
        }


        /// <summary>
        /// [20150813] add by Woody
        /// combo box district 
        /// </summary>
        /// <returns></returns>
        public List<District> DistrictAll(){
            
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction())
            {
                //var district = session.QueryOver<DistrictDomain>().Select(x => new District { id = x.DistrinctId, Name = x.DistrictName, ProvinceId = x.ProvinceId }).List<District>();
                var district = session.QueryOver<DistrictDomain>().List<DistrictDomain>().Select(x => new District { id = x.DistrinctId, Name = x.DistrictName, ProvinceId = x.ProvinceId }).ToList<District>();
                return district as List<District>;
            }
        
        }

        /// <summary>
        /// [20150813] add by Woody
        /// commbo box subdistrict 
        /// 
        /// </summary>
        /// <returns></returns>
        public List<SubDistrict> SubDistrictAll(){
        
            using(var session = SessionFactory.OpenStatelessSession())
            using(var tx = session.BeginTransaction()){

                var subdistrict = session.QueryOver<SubDistrictDomain>().List< SubDistrictDomain>().Select(x => new SubDistrict
                {
                    id = x.SubDistrictId,
                    ProvinceId = x.ProvinceId,
                    DistrinctId = x.DistrictId,
                    Name = x.SubDistrictName
                }).ToList<SubDistrict>();
            
                return subdistrict as List<SubDistrict>;
                
            }

        }

    }
}
