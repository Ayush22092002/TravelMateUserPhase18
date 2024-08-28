﻿using RoomBookingDll.Models;
using RoomBookingDll.Services;

namespace RoomBooking.Services
{
    public interface IRoomBookingDataService
    {
        Task AddRoomAsync(Room room, int hotelId);
        Task DeleteRoomByIdAsync(int roomId);
        Task<Room> GetRoomByIdAsync(int roomId);
        Task<List<Room>> GetAllRoomsAsync(int hotelId);
        Task<List<Room>> GetAvailableRoomsAsync();
        Task UpdateRoomAsync(Room room);
    }
    public class RoomDataService : IRoomBookingDataService
    {
        private readonly IRoomBookingService _roomService;

        public RoomDataService(IRoomBookingService roomService)
        {
            _roomService = roomService;
        }

        public Task AddRoomAsync(Room room, int hotelId)
        {
            return Task.Run(() => _roomService.AddNewRoom(room,hotelId));
        }

        public Task DeleteRoomByIdAsync(int roomId)
        {
            return Task.Run(() => _roomService.DeleteRoom(roomId));
        }

        public Task<Room> GetRoomByIdAsync(int roomId)
        {
            return Task.Run(() => _roomService.GetRoomById(roomId));
        }

        public Task<List<Room>> GetAllRoomsAsync(int hotelId)
        {
            return Task.Run(() => _roomService.GetAllRooms(hotelId));
        }

        public Task<List<Room>> GetAvailableRoomsAsync()
        {
            return Task.Run(() => _roomService.GetAvailableRooms());
        }

        public Task UpdateRoomAsync(Room room)
        {
            return Task.Run(() => _roomService.UpdateRoom(room));
        }
    }
}