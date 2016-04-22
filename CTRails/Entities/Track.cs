using CTRails.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CTRails.Entities.Employees;


namespace CTRails.Entities
{
    public class Track : Entity
    {
        //Fields
        private UnitOfWork worker;

        public int Number { get; private set; }


        /// <summary>
        /// The sectors that belong to the track.
        /// </summary>
        public List<Sector> Sectors
        {
            get
            {
                if (sectors != null)
                    return sectors;

                sectors = new List<Sector>();

                worker = new UnitOfWork(false);

                sectors = new List<Sector>(worker.Sectors.Where(s => s.TrackID == ID));

                return sectors;
            }
        }


        /// <summary>
        /// The routes that belong to the track.
        /// </summary>
        public List<Route> Routes
        {
            get
            {
                if (routes != null)
                    return routes;

                routes = new List<Route>();

                worker = new UnitOfWork();

                IEnumerable<TrackRoute> trackRoutes = worker.TrackRoutes.Where(track => track.TrackID == ID);

                foreach (TrackRoute tr in trackRoutes)
                    routes.AddRange(worker.Routes.Where(x => x.ID == tr.RouteID));


                return routes;
            }
        }


        private List<Route> routes;
        private List<Sector> sectors;

        public Track(int id) : base(id)
        {
            Number = id;
        }

        //Methoden
        public void Update()
        {
            List<Sector> sectors = Sectors.ToList();
            foreach (Sector s in sectors)
            {
                
            }
        }
    }
}

