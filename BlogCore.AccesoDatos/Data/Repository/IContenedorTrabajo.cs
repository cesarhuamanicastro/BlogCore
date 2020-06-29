using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public interface IContenedorTrabajo: IDisposable
    {
        //CONTENEDOR DE TRABAJO : ES DONDE SE TENDRA TODOS LOS REPOSITORIOS

        ICategoriaRepository Categoria { get; }

        IArticuloRepository Articulo { get; }

        void Save();

    }
}
