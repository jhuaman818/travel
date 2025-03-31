

using System.Collections.ObjectModel;

namespace travel.ViewModels
{
    public class InicioViewModel
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public ObservableCollection<Destination> Destinations { get; set; }


        public InicioViewModel()
        {
            Categorias = new ObservableCollection<Categoria>
            {
                new Categoria { Description = "PLAYA"},
                new Categoria { Description = "NATURALEZA"},
                new Categoria { Description = "MONTAÑA"},
                new Categoria { Description = "AVENTURA"},
                new Categoria { Description = "CANOPY"}
            };

            Destinations = new ObservableCollection<Destination>
            {
                new Destination { Name = "Selva central, Pichanaki", ImageUrl = "naturaleza.jpg", Description = "un lugar hermoso lleno de vegetacion" },
                new Destination { Name = "nevado huascaran, Huancayo", ImageUrl = "montana.jpg", Description = "hermoso nevado a las afueras de la ciudad de huancayo" },
                new Destination { Name = "lima capital, Peru", ImageUrl = "lima.jpg", Description = "la capital del peru donde se puede conocer mucha historia colonial"}
            };
        }
    }

    public class Destination
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }

   public class Categoria
    {
        public string Description { get; set; }
    }
}
