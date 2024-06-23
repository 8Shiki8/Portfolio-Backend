using System;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2Domain.Entities;

namespace _3AccessData
{
    public class GStoreDB:DbContext
    {
       
        public GStoreDB(DbContextOptions<GStoreDB> options) : base(options)
        {
        }
        // MOCKEAR LOS DATOS Y HACER UPDATEBASE
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<CarritoJuego> CarritoJuegos { get; set; }
        public DbSet<Categoria> Categorias{ get; set; }
        public DbSet<Juego> Juegos{ get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }

        public DbSet<CategoriaJuego> categoriaJuegos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuarios");
                entity.HasData(new Usuario
                {
                    usuarioId = 1,
                    nombre = "Diego",
                    apellido = "Martinez",
                    dni = "30456789",
                    email = "email@falso.com",

                });
                entity.ToTable("Usuarios");
                entity.HasData(new Usuario
                {
                    usuarioId = 2,
                    nombre = "Alberto",
                    apellido = "Martinez",
                    dni = "30458889",
                    email = "email@falso.com",

                });
                entity.ToTable("Usuarios");
                entity.HasData(new Usuario
                {
                    usuarioId = 3,
                    nombre = "Julio",
                    apellido = "Rodriguez",
                    dni = "30457999",
                    email = "email@falso.com",

                });
                entity.ToTable("Usuarios");
                entity.HasData(new Usuario
                {
                    usuarioId = 4,
                    nombre = "Mario",
                    apellido = "Bros",
                    dni = "30321789",
                    email = "email@falso.com",

                });

            });
            modelBuilder.Entity<Carrito>(entity =>
            {
                entity.ToTable("Carritos");
                entity.HasData(new Carrito
                {
                    carritoId = 1,
                    usuarioId = 1,
                    total = 1650,

                });

                entity.ToTable("Carritos");
                entity.HasData(new Carrito
                {
                    carritoId = 2,
                    usuarioId = 2,
                    total = 1750,

                });
            });
            modelBuilder.Entity<Juego>(entity =>
            {

                entity.ToTable("Juegos");
                entity.HasData(new Juego
                {
                    juegoId = 1,
                    nombre = "God of War",
                    descripcion = "PlayStation",
                    precio = 9000,
                    imagen = "https://kalimagames.com/wp-content/uploads/2022/06/god-of-war-cover-ps4.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 2,
                    nombre = "Final Fantasy XV",
                    descripcion = "PlayStation",
                    precio = 10000,
                    imagen = "https://d3ugyf2ht6aenh.cloudfront.net/stores/001/054/804/products/final-fantasy-xv-1pre1-1d968ea8634df9059016615194247849-1024-1024.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 3,
                    nombre = "Nier Automata",
                    descripcion = "PlayStation",
                    precio = 12000,
                    imagen = "https://media.vandal.net/m/31670/nier-automata-201739151954_1.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 4,
                    nombre = "Grand Blue Fantasy VS",
                    descripcion = "PlayStation",
                    precio = 80000,
                    imagen = "https://media.vandal.net/m/68948/granblue-fantasy-versus-20202281558476_1.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 5,
                    nombre = "Uncharted 4",
                    descripcion = "PlayStation",
                    precio = 8000,
                    imagen = "https://img.asmedia.epimg.net/resizer/nLnnwOnepXsO4SxQi5clD-OMDU4=/1472x0/cloudfront-eu-central-1.images.arcpublishing.com/diarioas/UXT2MHW3GZIZVICCIMPIDDZEBQ.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 6,
                    nombre = "Ghost of Tsushima",
                    descripcion = "PlayStation",
                    precio = 8000,
                    imagen = "https://uvejuegos.com/img/caratulas/59884/ghostps4.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 7,
                    nombre = "Control",
                    descripcion = "PlayStation",
                    precio = 8000,
                    imagen = "https://uvejuegos.com/img/caratulas/61273/control_ps4.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 8,
                    nombre = "Resident Evil 4",
                    descripcion = "PlayStation",
                    precio = 8000,
                    imagen = "https://uvejuegos.com/img/caratulas/56484/ps4.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 9,
                    nombre = "Resident Evil 3",
                    descripcion = "PlayStation",
                    precio = 8000,
                    imagen = "https://cybergamesemanuel.com/wp-content/uploads/2020/04/Resident-evil-3-2.jpg"
                });
                entity.HasData(new Juego
                {
                    juegoId = 10,
                    nombre = "Battlefield V",
                    descripcion = "PlayStation",
                    precio = 8000,
                    imagen = "https://uvejuegos.com/img/caratulas/61051/Battlefield-V-PS4.jpg"
                });

            });

            modelBuilder.Entity<Categoria>(entity =>
            {

                entity.ToTable("Categorias");
                entity.HasData(new Categoria
                {
                    categoriaId = 1,
                    tipo = "RPG"

                });

                entity.ToTable("Categorias");
                entity.HasData(new Categoria
                {
                    categoriaId = 2,
                    tipo = "FPS"

                });
                entity.ToTable("Categorias");
                entity.HasData(new Categoria
                {
                    categoriaId = 3,
                    tipo = "Terror"

                });
                entity.ToTable("Categorias");
                entity.HasData(new Categoria
                {
                    categoriaId = 4,
                    tipo = "Pelea"

                });
                entity.ToTable("Categorias");
                entity.HasData(new Categoria
                {
                    categoriaId = 5,
                    tipo = "Accion"

                });
                entity.ToTable("Categorias");
                entity.HasData(new Categoria
                {
                    categoriaId = 6,
                    tipo = "Fantasia"

                });
            });
            modelBuilder.Entity<CategoriaJuego>(entity =>
            {
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 1,
                    CategoriaId = 1,
                    JuegoId = 2,


                });

                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 2,
                    CategoriaId = 5,
                    JuegoId = 1,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 3,
                    CategoriaId = 6,
                    JuegoId = 1,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 4,
                    CategoriaId = 1,
                    JuegoId = 3,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 5,
                    CategoriaId = 5,
                    JuegoId = 3,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 6,
                    CategoriaId = 4,
                    JuegoId = 4,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 7,
                    CategoriaId = 5,
                    JuegoId = 5,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 8,
                    CategoriaId = 5,
                    JuegoId = 6,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 9,
                    CategoriaId = 6,
                    JuegoId = 6,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 10,
                    CategoriaId = 5,
                    JuegoId = 7,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 11,
                    CategoriaId = 6,
                    JuegoId = 7,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 12,
                    CategoriaId = 3,
                    JuegoId = 8,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 13,
                    CategoriaId = 5,
                    JuegoId = 8,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 14,
                    CategoriaId = 3,
                    JuegoId = 9,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 15,
                    CategoriaId = 5,
                    JuegoId = 9,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 16,
                    CategoriaId = 2,
                    JuegoId = 10,


                });
                entity.ToTable("CategoriaJuegos");
                entity.HasData(new CategoriaJuego
                {
                    //rpg fps terror pelea accion fantasia
                    Id = 17,
                    CategoriaId = 5,
                    JuegoId = 10,


                });

            });
        }


    }
}
