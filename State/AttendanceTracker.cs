using System.Collections.Generic;

namespace BlazorFinalProject.State
{
    public class AttendanceTracker
    {
        // Key: EventId, Value: List of attendee emails
        private readonly Dictionary<int, List<string>> _attendance = new();

        public void RegisterAttendance(int eventId, string userEmail)
        {
            if (!_attendance.ContainsKey(eventId))
            {
                _attendance[eventId] = new List<string>();
            }
            if (!_attendance[eventId].Contains(userEmail))
            {
                _attendance[eventId].Add(userEmail);
            }
        }

        public IReadOnlyList<string> GetAttendees(int eventId)
        {
            return _attendance.ContainsKey(eventId) ? _attendance[eventId].AsReadOnly() : new List<string>().AsReadOnly();
        }

        public int GetAttendanceCount(int eventId)
        {
            return _attendance.ContainsKey(eventId) ? _attendance[eventId].Count : 0;
        }
    }
}
