﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutdal;
        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public About GetByID(int id)
        {
            return _aboutdal.GetByID(id);
        }

        public void TDelete(About entity)
        {
            _aboutdal.Delete(entity);
        }

        public List<About> TGetList()
        {
            return _aboutdal.GetAll();
        }

        public void TInsert(About entity)
        {
            _aboutdal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutdal.Update(entity);
        }
    }
}
