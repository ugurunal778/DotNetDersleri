INSERT [dbo].[Categories] ([CategoryID], [Categories]) VALUES (1, N'Crime')
GO
INSERT [dbo].[Categories] ([CategoryID], [Categories]) VALUES (2, N'Drama')
GO
INSERT [dbo].[Categories] ([CategoryID], [Categories]) VALUES (3, N'Adventure')
GO
INSERT [dbo].[Categories] ([CategoryID], [Categories]) VALUES (4, N'Comedy')
GO
INSERT [dbo].[Categories] ([CategoryID], [Categories]) VALUES (5, N'Sci-Fi')
GO
INSERT [dbo].[Categories] ([CategoryID], [Categories]) VALUES (6, N'Animation')
GO
INSERT [dbo].[Categories] ([CategoryID], [Categories]) VALUES (7, N'Fantasy')
GO
INSERT [dbo].[Categories] ([CategoryID], [Categories]) VALUES (8, N'Action')
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (1, N'The Shawshank Redemption', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', 142)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (2, N'Back to the Future', N'Marty McFly, a 17-year-old high school student, is accidentally sent 30 years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.', 114)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (3, N'Forrest Gump', N'Forrest Gump, while not intelligent, has accidentally been present at many historic moments, but his true love, Jenny Curran, eludes him.', 142)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (4, N'Fight Club', N'An insomniac office worker, looking for a way to change his life, crosses paths with a devil-may-care soap maker, forming an underground fight club that evolves into something much, much more.', 140)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (5, N'The Lion King', N'Lion cub and future king Simba searches for his identity. His eagerness to please others and penchant for testing his boundaries sometimes gets him into trouble.', 90)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (6, N'Back to the Future 2', N'After visiting 2015, Marty McFly must repeat his visit to 1955 to prevent disastrous changes to 1985...without interfering with his first trip.', 110)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (7, N'The Truman Show', N'An insurance salesman/adjuster discovers his entire life is actually a television show.', 105)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (8, N'Ice Age', N'Set during the Ice Age, a sabertooth tiger, a sloth, and a wooly mammoth find a lost human infant, and they try to return him to his tribe.', 81)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (9, N'The Green Mile', N'The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.', 190)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (10, N'Back to the Future 3', N'Enjoying a peaceable existence in 1885, Doctor Emmet Brown is about to be killed by Buford "Mad Dog" Tannen. Marty McFly travels back in time to save his friend.', 120)
GO
INSERT [dbo].[Movies] ([MovieID], [Movie], [Description], [Duration]) VALUES (11, N'The Matrix', N'A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.', 140)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (1, 1)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (1, 2)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (2, 3)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (2, 4)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (2, 5)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (3, 4)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (3, 2)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (4, 2)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (5, 6)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (5, 3)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (5, 2)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (6, 3)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (6, 4)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (6, 5)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (7, 4)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (7, 2)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (7, 5)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (8, 6)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (8, 3)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (8, 4)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (9, 1)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (9, 2)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (9, 7)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (10, 3)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (10, 4)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (10, 5)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (11, 8)
GO
INSERT [dbo].[MoviesCategories] ([MovieID], [CategoryID]) VALUES (11, 5)
GO
INSERT [dbo].[Saloons] ([SaloonID], [Saloons], [Capacity]) VALUES (1, N'A', 40)
GO
INSERT [dbo].[Saloons] ([SaloonID], [Saloons], [Capacity]) VALUES (2, N'B', 58)
GO
INSERT [dbo].[Saloons] ([SaloonID], [Saloons], [Capacity]) VALUES (3, N'C', 94)
GO
INSERT [dbo].[Saloons] ([SaloonID], [Saloons], [Capacity]) VALUES (4, N'D', 72)
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (1, CAST(N'1899-12-30T11:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (2, CAST(N'1899-12-30T12:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (3, CAST(N'1899-12-30T13:30:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (4, CAST(N'1899-12-30T14:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (5, CAST(N'1899-12-30T15:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (6, CAST(N'1899-12-30T16:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (7, CAST(N'1899-12-30T17:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (8, CAST(N'1899-12-30T18:30:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (9, CAST(N'1899-12-30T19:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (10, CAST(N'1899-12-30T20:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (11, CAST(N'1899-12-30T21:00:00.000' AS DateTime))
GO
INSERT [dbo].[Sessions] ([SessionID], [Sessions]) VALUES (12, CAST(N'1899-12-30T21:30:00.000' AS DateTime))
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (1, 1, 1, 1, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (2, 1, 4, 1, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (3, 1, 7, 1, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (4, 1, 10, 1, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (5, 1, 8, 2, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (6, 1, 12, 2, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (7, 2, 1, 2, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (8, 2, 3, 2, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (9, 2, 6, 2, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (10, 3, 1, 3, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (11, 3, 4, 3, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (12, 3, 7, 3, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (13, 3, 10, 3, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (14, 4, 8, 4, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (15, 4, 12, 4, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (16, 5, 2, 4, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (17, 5, 4, 4, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (18, 5, 6, 4, 1)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (19, 1, 1, 1, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (20, 1, 4, 1, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (21, 1, 7, 1, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (22, 1, 10, 1, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (23, 6, 1, 2, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (24, 6, 3, 2, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (25, 6, 6, 2, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (26, 6, 8, 2, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (27, 6, 11, 2, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (28, 7, 1, 3, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (29, 7, 3, 3, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (30, 7, 6, 3, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (31, 7, 8, 3, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (32, 7, 11, 3, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (33, 4, 8, 4, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (34, 4, 12, 4, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (35, 8, 2, 4, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (36, 8, 4, 4, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (37, 8, 6, 4, 2)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (38, 9, 1, 1, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (39, 9, 5, 1, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (40, 9, 9, 1, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (41, 9, 6, 3, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (42, 9, 10, 3, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (43, 10, 1, 2, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (44, 10, 3, 2, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (45, 10, 6, 2, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (46, 10, 8, 2, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (47, 10, 11, 2, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (48, 7, 1, 3, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (49, 7, 3, 3, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (50, 11, 1, 4, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (51, 11, 4, 4, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (52, 11, 7, 4, 3)
GO
INSERT [dbo].[Theaters] ([ID], [MovieID], [SessionID], [SaloonID], [WeekID]) VALUES (53, 11, 10, 4, 3)
GO
INSERT [dbo].[Weeks] ([WeekID], [Week], [Week First Day], [Week Last Day]) VALUES (1, N'W32', CAST(N'2016-08-08T00:00:00.000' AS DateTime), CAST(N'2016-08-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Weeks] ([WeekID], [Week], [Week First Day], [Week Last Day]) VALUES (2, N'W33', CAST(N'2016-08-15T00:00:00.000' AS DateTime), CAST(N'2016-08-21T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Weeks] ([WeekID], [Week], [Week First Day], [Week Last Day]) VALUES (3, N'W34', CAST(N'2016-08-22T00:00:00.000' AS DateTime), CAST(N'2016-08-28T00:00:00.000' AS DateTime))
GO