# 📖 Gestion Libreria - Prueba tecnica

Este es el repositorio de un proyecto simple de Gestion de Libreriahecho en ASP.NET MVC. Donde se pueden ver los Libros en la pagina principal mas dos opciones de agregar un Libro y un Autor

![Imagen-Proyecto](./wwwroot/img/ShotsGL.png)

### 💡 Tecnologias Utilizadas

- Entity Framework Core
- Tailwind CSS

## 🚀 Getting Started

Clonar proyecto atravez de Git

```bash
git clone https://github.com/G4BO11/GestionLibreria-PruebaTecnica.git
```

Clonar proyecto atravez de GitHub CLI

```shell
gh repo clone G4BO11/GestionLibreria-PruebaTecnica
```

Descargar .NET (En caso de no tener .NET en el computador)

[![Descargar .NET](./wwwroot/img/BtnDescargaNET.png)](https://stackblitz.com/github/withastro/astro/tree/latest/examples/basics)

Iniciar proyecto atravez de la terminal

```shell
dotnet run
```

## 🧞 Comandos

Estos son los comandos que puedes utilizar en la terminal para ejecutar el proyecto si es necesario:

| Comando            | Accion                                |
| :----------------- | :------------------------------------ |
| `pnpm install`     | Instalar Dependecias (tailwind)       |
| `dotnet --version` | Te muestra que version de .NET tienes |
| `dotnet run`       | Ejecuta el proyecto                   |

## 🗃️ Diagrama Entidad Relacion

![Imagen-DataBase](./wwwroot/img/ShotsDiagrama.png)

## 📄 Script Database

```sql
    USE [GestionLibros]
    GO
    /****** Object:  Table [dbo].[Autores]  ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
    CREATE TABLE [dbo].[Autores](
        [AutorId] [int] IDENTITY(1,1) NOT NULL,
        [Nombre] [nvarchar](max) NOT NULL,
    CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED
    (
        [AutorId] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
    /****** Object:  Table [dbo].[Libros]  ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
    CREATE TABLE [dbo].[Libros](
        [LibroID] [int] IDENTITY(1,1) NOT NULL,
        [LibTitulo] [nvarchar](max) NOT NULL,
        [LibGenero] [nvarchar](max) NOT NULL,
        [AutorID] [int] NOT NULL,
    CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED
    (
        [LibroID] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
    ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Autores_AutorID] FOREIGN KEY([AutorID])
    REFERENCES [dbo].[Autores] ([AutorId])
    ON DELETE CASCADE
    GO
    ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Autores_AutorID]
    GO
```
