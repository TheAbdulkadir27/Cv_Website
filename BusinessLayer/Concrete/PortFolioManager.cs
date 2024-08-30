﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PortFolioManager : IPortFolioService
    {
        private readonly IPortFolioDal _portFoliodal;
        public PortFolioManager(IPortFolioDal portFoliodal)
        {
            _portFoliodal = portFoliodal;
        }

        public PortFolio GetByID(int id)
        {
            return _portFoliodal.GetByID(id);
        }

        public void TDelete(PortFolio entity)
        {
            _portFoliodal.Delete(entity);
        }

        public List<PortFolio> TGetList()
        {
            return _portFoliodal.GetAll();
        }

        public void TInsert(PortFolio entity)
        {
            _portFoliodal.Insert(entity);
        }

        public void TUpdate(PortFolio entity)
        {
            _portFoliodal.Update(entity);
        }
    }
}
