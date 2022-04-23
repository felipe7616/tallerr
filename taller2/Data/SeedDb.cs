namespace taller2.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntranceAsync();
            await CheckTicketAsync();

        }

        private async Task CheckTicketAsync()
        { 
            if (!_context.Tickets.Any())
            {  for (int c = 1;c<=5000;c++) {
                    _context.Tickets.Add(new Ticket { WasUsed = false }); }
               
            }
        }

        private async Task CheckEntranceAsync()
        {
            if (!_context.entrances.Any())
            {
                _context.entrances.Add(new Entrance { Description = "Norte" });
                _context.entrances.Add(new Entrance { Description = "Sur" });
                _context.entrances.Add(new Entrance { Description = "Orienta" });
                _context.entrances.Add(new Entrance { Description = "Occidental" });
                await _context.SaveChangesAsync();   
            }
           
        }

    }
}
