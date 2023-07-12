namespace cjuridico.Domain.CQ.Commands.Requests
{
    public class DeleteRequest
    {
        public DeleteRequest(Guid entityId)
        {
            EntityId = entityId;
        }
        
        public Guid EntityId { get; set; }
    }
}