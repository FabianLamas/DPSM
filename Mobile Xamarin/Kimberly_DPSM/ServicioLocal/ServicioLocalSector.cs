using System;
using System.Collections.Generic;
using System.ComponentModel;
using Modelos;

namespace Kimberly_DPSM.ServicioLocal
{
    public class ServicioLocalSector : INotifyPropertyChanged
    {
        public ServicioLocalSector()
        {
            FillSectores();
        }
        private List<Sector> GetSectors = new List<Sector>();

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Sector> FillSectores()
        {
            if (GetSectors.Count < 1)
            {
                GetSectors.Add(new Sector("A001", "Adult"));
                GetSectors.Add(new Sector("A002", "Family"));
                GetSectors.Add(new Sector("A003", "BBC"));
                GetSectors.Add(new Sector("A005", "Femenine"));
            }

            return GetSectors;
        }

        //public List<Sector> GetSectors
        //{
        //    set
        //    {
        //        if (_GetSectors == null)
        //            return;

        //        _GetSectors = new List<Sector>();
        //        _GetSectors = value;
        //        OnProperty(nameof(GetSectors));

        //    }
        //    get
        //    {
        //        if (_GetSectors != null)
        //            return _GetSectors;
        //    }
        //}

        private void OnProperty(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
