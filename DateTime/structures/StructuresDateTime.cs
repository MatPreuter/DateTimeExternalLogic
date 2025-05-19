using OutSystems.ExternalLibraries.SDK;

namespace DateTime.structures
{
    [OSStructure(
        Description = ""
    )]
    public struct TimeZoneInfo {
        [OSStructureField(
            DataType = OSDataType.Integer,
            Description = "",
            IsMandatory = true
        )]
        public int BaseUtcOffsetHours;
        [OSStructureField(
            DataType = OSDataType.Integer,
            Description = "",
            IsMandatory = true
        )]
        public int BaseUtcOffsetMinutes;
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = true,
            Length = 50
        )]
        public string DaylightName;
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = true,
            Length = 50
        )]
        public string DisplayName;
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = true,
            Length = 50
        )]
        public string Id;
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = true,
            Length = 50
        )]
        public string StandardName;
        [OSStructureField(
            DataType = OSDataType.Boolean,
            Description = "",
            IsMandatory = true
        )]
        public bool SupportDaylightSavingTime;
    }

}