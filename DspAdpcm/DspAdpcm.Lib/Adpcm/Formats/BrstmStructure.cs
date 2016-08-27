namespace DspAdpcm.Lib.Adpcm.Formats
{
    /// <summary>
    /// Defines the structure and metadata
    /// of a BRSTM file.
    /// </summary>
    public class BrstmStructure : B_stmStructure
    {
        /// <summary>
        /// The length of the entire BRSTM file.
        /// </summary>
        public int FileLength { get; set; }
        /// <summary>
        /// The version listed in the RSTM header.
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// The length of the RSTM header.
        /// </summary>
        public int RstmHeaderLength { get; set; }
        /// <summary>
        /// The number of sections listed in the RSTM header.
        /// </summary>
        public int RstmHeaderSections { get; set; }
        /// <summary>
        /// The offset of the HEAD chunk.
        /// </summary>
        public int HeadChunkOffset { get; set; }
        /// <summary>
        /// The length of the HEAD chunk as stated in the
        /// RSTM header.
        /// </summary>
        public int HeadChunkLengthRstm { get; set; }
        /// <summary>
        /// The offset of the ADPC chunk.
        /// </summary>
        public int AdpcChunkOffset { get; set; }
        /// <summary>
        /// The length of the ADPC chunk as stated in the
        /// RSTM header.
        /// </summary>
        public int AdpcChunkLengthRstm { get; set; }
        /// <summary>
        /// The offset of the DATA chunk.
        /// </summary>
        public int DataChunkOffset { get; set; }
        /// <summary>
        /// The length of the DATA chunk as stated in the
        /// RSTM header.
        /// </summary>
        public int DataChunkLengthRstm { get; set; }

        /// <summary>
        /// The length of the HEAD chunk as stated in the
        /// HEAD chunk header.
        /// </summary>
        public int HeadChunkLength { get; set; }
        /// <summary>
        /// The offset of part 1 of the HEAD chunk.
        /// </summary>
        public int HeadChunk1Offset { get; set; }
        /// <summary>
        /// The offset of part 2 of the HEAD chunk.
        /// </summary>
        public int HeadChunk2Offset { get; set; }
        /// <summary>
        /// The offset of part 3 of the HEAD chunk.
        /// </summary>
        public int HeadChunk3Offset { get; set; }
        /// <summary>
        /// The length of part 1 of the HEAD chunk.
        /// </summary>
        public int HeadChunk1Length => HeadChunk2Offset - HeadChunk1Offset;
        /// <summary>
        /// The length of part 2 of the HEAD chunk.
        /// </summary>
        public int HeadChunk2Length => HeadChunk3Offset - HeadChunk2Offset;
        /// <summary>
        /// The length of part 3 of the HEAD chunk.
        /// </summary>
        public int HeadChunk3Length => HeadChunkLength - HeadChunk3Offset;

        /// <summary>
        /// The length of the ADPC chunk as stated in the
        /// ADPC chunk header.
        /// </summary>
        public int AdpcChunkLength { get; set; }
        /// <summary>
        /// Specifies whether the seek table is full
        /// length, or a truncated table used in some
        /// games including Pok�mon Battle Revolution
        /// and Mario Party 8. 
        /// </summary>
        public BrstmSeekTableType SeekTableType { get; set; }

        /// <summary>
        /// The length of the DATA chunk as stated in the
        /// DATA chunk header.
        /// </summary>
        public int DataChunkLength { get; set; }

        /// <summary>
        /// The audio codec.
        /// </summary>
        public BrstmCodec Codec { get; set; }

        /// <summary>
        /// The type of description used for the tracks
        /// in part 2 of the HEAD chunk.
        /// </summary>
        public BrstmTrackType HeaderType { get; set; }
    }

    /// <summary>
    /// Defines the ADPCM information for a single
    /// ADPCM channel.
    /// </summary>
    public class BrstmChannelInfo : AdpcmChannelInfo
    {
        /// <summary>
        /// The offset of the coefficients of the
        /// channel. Used in a BRSTM header.
        /// </summary>
        public int Offset { get; set; }
    }

    /// <summary>
    /// The different types of seek tables used in BRSTM files.
    /// </summary>
    public enum BrstmSeekTableType
    {
        /// <summary>
        /// A normal length, complete seek table.
        /// </summary>
        Standard,
        /// <summary>
        /// A shortened, truncated seek table used in games 
        /// including Pok�mon Battle Revolution and Mario Party 8.
        /// </summary>
        Short
    }

    /// <summary>
    /// The different track description types used in BRSTM files.
    /// </summary>
    public enum BrstmTrackType
    {
        /// <summary>
        /// The track description used in most games other than 
        /// Super Smash Bros. Brawl.
        /// </summary>
        Standard,
        /// <summary>
        /// The track description used in Super Smash Bros. Brawl.
        /// It does not contain values for volume or panning.
        /// </summary>
        Short
    }

    /// <summary>
    /// The different audio codecs used in BRSTM files.
    /// </summary>
    public enum BrstmCodec
    {
        /// <summary>
        /// Big-endian, 8-bit PCM
        /// </summary>
        Pcm8Bit = 0,
        /// <summary>
        /// Big-endian, 16-bit PCM
        /// </summary>
        Pcm16Bit = 1,
        /// <summary>
        /// Nintendo's 4-Bit ADPCM
        /// </summary>
        Adpcm = 2
    }
}