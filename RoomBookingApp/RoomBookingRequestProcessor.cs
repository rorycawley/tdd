using System.ComponentModel.DataAnnotations;

namespace RoomBookingApp
{
    public class RoomBookingRequestProcessor
    {
        public class RoomBookingRequest
        {
            [Required]
            public string FullName { get; set; }

            [Required]
            public string Email { get; set; }

            public DateTime Date { get; set; }
        }

        public class RoomBookingResult
        {
            public string FullName { get; set; }
            public string Email { get; set; }
            public DateTime Date { get; set; }
        }

        public RoomBookingResult BookRoom(RoomBookingRequest bookingRequest)
        {
            // TODO: Implement this method to book a room and return a valid RoomBookingResult instance
            throw new NotImplementedException();
        }
    }
}