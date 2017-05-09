<Query Kind="Statements">
  <Connection>
    <ID>513b95fc-8765-401a-9b50-d55980f712e4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from a in Artists
              orderby a.Name descending
			  select new
			  {
			     ID = a.ArtistId,
				 Name = a.Name
			 };
results.Dump();