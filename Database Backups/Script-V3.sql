USE [CarSales]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Client](
	[IdPersonne] [int] NOT NULL,
	[TypeClient] [int] NOT NULL,
	[Siret] [varchar](100) NOT NULL,
	[NomEntreprise] [varchar](100) NOT NULL,
	[AdresseEntreprise] [varchar](100) NOT NULL,
	[CodePostal] [varchar](100) NOT NULL,
	[VilleEntreprise] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[IdPersonne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConstructeursVoiture]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConstructeursVoiture](
	[Nom] [varchar](100) NOT NULL,
	[Adresse1] [varchar](100) NOT NULL,
	[Adresse2] [varchar](100) NULL,
	[Zip] [varchar](100) NOT NULL,
	[Ville] [varchar](100) NOT NULL,
	[Pays] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ConstructeursVoiture] PRIMARY KEY CLUSTERED 
(
	[Nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ContratAchat]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ContratAchat](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEmploye] [int] NOT NULL,
	[IdVehicule] [char](9) NOT NULL,
	[DateContrat] [datetime] NOT NULL,
 CONSTRAINT [PK_Contrat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employe](
	[IdPersonne] [int] NOT NULL,
	[MotDePasse] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED 
(
	[IdPersonne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Facture]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facture](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateFacturation] [datetime] NOT NULL,
 CONSTRAINT [PK_Facture] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Location]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Location](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdEmploye] [int] NOT NULL,
	[IdVehicule] [char](9) NOT NULL,
	[DateDebut] [datetime] NOT NULL,
	[PrixLocation] [decimal](18, 2) NOT NULL,
	[Duree] [int] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Operation]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Operation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdFacture] [int] NOT NULL,
	[IdImmatriculation] [char](9) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[Duree] [decimal](18, 2) NOT NULL,
	[DateOperation] [datetime] NOT NULL,
 CONSTRAINT [PK_Operation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personne]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personne](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](100) NOT NULL,
	[Prenom] [varchar](100) NOT NULL,
	[Adresse1] [varchar](100) NOT NULL,
	[Adresse2] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[NumeroTelephone] [varchar](100) NOT NULL,
	[CodePostal] [varchar](100) NOT NULL,
	[Ville] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Personne] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Piece]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Piece](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdOperation] [int] NULL,
	[Description] [varchar](100) NOT NULL,
	[Prix] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Piece] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plein]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plein](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdFournisseur] [int] NOT NULL,
	[IdImmatriculation] [char](9) NOT NULL,
	[DatePlein] [datetime] NOT NULL,
	[Volume] [decimal](18, 2) NOT NULL,
	[PrixLitre] [decimal](18, 2) NOT NULL,
	[Kilometrage] [int] NOT NULL,
 CONSTRAINT [PK_Plein] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TauxHoraire]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TauxHoraire](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdOperation] [int] NOT NULL,
	[Valeur] [decimal](18, 2) NOT NULL,
	[TauxActuel] [bit] NOT NULL,
	[DateModification] [datetime] NOT NULL,
 CONSTRAINT [PK_TauxHoraire] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vehicule]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehicule](
	[Immatriculation] [char](9) NOT NULL,
	[IdClient] [int] NOT NULL,
	[Marque] [varchar](100) NOT NULL,
	[Puissance] [int] NOT NULL,
	[Couleur] [varchar](100) NOT NULL,
	[Modele] [varchar](100) NOT NULL,
	[Kilometrage] [int] NOT NULL,
	[PrixAchat] [decimal](18, 2) NOT NULL,
	[DateAchat] [datetime] NOT NULL,
	[DateVente] [datetime] NOT NULL,
 CONSTRAINT [PK_Vehicule] PRIMARY KEY CLUSTERED 
(
	[Immatriculation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VehiculeNeuf]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehiculeNeuf](
	[Immatriculation] [char](9) NOT NULL,
 CONSTRAINT [PK_VehiculeNeuf] PRIMARY KEY CLUSTERED 
(
	[Immatriculation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VehiculeOccasion]    Script Date: 21-Sep-18 8:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehiculeOccasion](
	[Immatriculation] [char](9) NOT NULL,
	[KilometrageAchat] [int] NOT NULL,
	[KilometrageVente] [int] NOT NULL,
 CONSTRAINT [PK_VehiculeOccasion] PRIMARY KEY CLUSTERED 
(
	[Immatriculation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Personne] FOREIGN KEY([IdPersonne])
REFERENCES [dbo].[Personne] ([Id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Personne]
GO
ALTER TABLE [dbo].[ContratAchat]  WITH CHECK ADD  CONSTRAINT [FK_ContratAchat_Employe] FOREIGN KEY([IdEmploye])
REFERENCES [dbo].[Employe] ([IdPersonne])
GO
ALTER TABLE [dbo].[ContratAchat] CHECK CONSTRAINT [FK_ContratAchat_Employe]
GO
ALTER TABLE [dbo].[ContratAchat]  WITH CHECK ADD  CONSTRAINT [FK_ContratAchat_Vehicule] FOREIGN KEY([IdVehicule])
REFERENCES [dbo].[Vehicule] ([Immatriculation])
GO
ALTER TABLE [dbo].[ContratAchat] CHECK CONSTRAINT [FK_ContratAchat_Vehicule]
GO
ALTER TABLE [dbo].[Employe]  WITH CHECK ADD  CONSTRAINT [FK_Employe_Personne] FOREIGN KEY([IdPersonne])
REFERENCES [dbo].[Personne] ([Id])
GO
ALTER TABLE [dbo].[Employe] CHECK CONSTRAINT [FK_Employe_Personne]
GO
ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [FK_Location_Client] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdPersonne])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Client]
GO
ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [FK_Location_Employe] FOREIGN KEY([IdVehicule])
REFERENCES [dbo].[VehiculeNeuf] ([Immatriculation])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Employe]
GO
ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [FK_Location_Employe1] FOREIGN KEY([IdEmploye])
REFERENCES [dbo].[Employe] ([IdPersonne])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Employe1]
GO
ALTER TABLE [dbo].[Operation]  WITH CHECK ADD  CONSTRAINT [FK_Operation_Facture] FOREIGN KEY([IdFacture])
REFERENCES [dbo].[Facture] ([Id])
GO
ALTER TABLE [dbo].[Operation] CHECK CONSTRAINT [FK_Operation_Facture]
GO
ALTER TABLE [dbo].[Operation]  WITH CHECK ADD  CONSTRAINT [FK_Operation_Vehicule] FOREIGN KEY([IdImmatriculation])
REFERENCES [dbo].[Vehicule] ([Immatriculation])
GO
ALTER TABLE [dbo].[Operation] CHECK CONSTRAINT [FK_Operation_Vehicule]
GO
ALTER TABLE [dbo].[Piece]  WITH CHECK ADD  CONSTRAINT [FK_Piece_Operation] FOREIGN KEY([IdOperation])
REFERENCES [dbo].[Operation] ([Id])
GO
ALTER TABLE [dbo].[Piece] CHECK CONSTRAINT [FK_Piece_Operation]
GO
ALTER TABLE [dbo].[Plein]  WITH CHECK ADD  CONSTRAINT [FK_Plein_Client] FOREIGN KEY([IdFournisseur])
REFERENCES [dbo].[Client] ([IdPersonne])
GO
ALTER TABLE [dbo].[Plein] CHECK CONSTRAINT [FK_Plein_Client]
GO
ALTER TABLE [dbo].[Plein]  WITH CHECK ADD  CONSTRAINT [FK_Plein_Vehicule] FOREIGN KEY([IdImmatriculation])
REFERENCES [dbo].[Vehicule] ([Immatriculation])
GO
ALTER TABLE [dbo].[Plein] CHECK CONSTRAINT [FK_Plein_Vehicule]
GO
ALTER TABLE [dbo].[TauxHoraire]  WITH CHECK ADD  CONSTRAINT [FK_TauxHoraire_Operation] FOREIGN KEY([IdOperation])
REFERENCES [dbo].[Operation] ([Id])
GO
ALTER TABLE [dbo].[TauxHoraire] CHECK CONSTRAINT [FK_TauxHoraire_Operation]
GO
ALTER TABLE [dbo].[Vehicule]  WITH CHECK ADD  CONSTRAINT [FK_Vehicule_Client] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdPersonne])
GO
ALTER TABLE [dbo].[Vehicule] CHECK CONSTRAINT [FK_Vehicule_Client]
GO
ALTER TABLE [dbo].[Vehicule]  WITH CHECK ADD  CONSTRAINT [FK_Vehicule_ConstructeursVoiture] FOREIGN KEY([Marque])
REFERENCES [dbo].[ConstructeursVoiture] ([Nom])
GO
ALTER TABLE [dbo].[Vehicule] CHECK CONSTRAINT [FK_Vehicule_ConstructeursVoiture]
GO
ALTER TABLE [dbo].[VehiculeNeuf]  WITH CHECK ADD  CONSTRAINT [FK_VehiculeNeuf_Vehicule] FOREIGN KEY([Immatriculation])
REFERENCES [dbo].[Vehicule] ([Immatriculation])
GO
ALTER TABLE [dbo].[VehiculeNeuf] CHECK CONSTRAINT [FK_VehiculeNeuf_Vehicule]
GO
ALTER TABLE [dbo].[VehiculeOccasion]  WITH CHECK ADD  CONSTRAINT [FK_VehiculeOccasion_Vehicule] FOREIGN KEY([Immatriculation])
REFERENCES [dbo].[Vehicule] ([Immatriculation])
GO
ALTER TABLE [dbo].[VehiculeOccasion] CHECK CONSTRAINT [FK_VehiculeOccasion_Vehicule]
GO
