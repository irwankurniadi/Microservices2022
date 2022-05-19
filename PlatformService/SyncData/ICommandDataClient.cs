using PlatformService.Dtos;

namespace PlatformService.SyncData
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);   
    }
}