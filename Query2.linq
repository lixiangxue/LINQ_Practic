<Query Kind="Statements">
  <Connection>
    <ID>513b95fc-8765-401a-9b50-d55980f712e4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
              where x.ArtistId == 1
			  orderby x.Name
			  select new
			  {
			   Artist = x.Name,
			   Albums= from t in x.Ablums
			           orderby b.Title
					   select new
			   {
				   Title = b.Title,
				   Year = b.ReleaseYear,
				   Label = b.
			   }
			  };
results.Dump();