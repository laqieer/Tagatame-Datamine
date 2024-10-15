// Decompiled with JetBrains decompiler
// Type: SRPG.VersusTowerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ECA")]
  public class VersusTowerParam
  {
    [Token(Token = "0x400814A")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int RANK_RANGE;
    [Token(Token = "0x400814B")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int RANK_NUM;
    [Token(Token = "0x400814C")]
    [FieldOffset(Offset = "0x8")]
    public OString VersusTowerID;
    [Token(Token = "0x400814D")]
    [FieldOffset(Offset = "0xC")]
    public OString FloorName;
    [Token(Token = "0x400814E")]
    [FieldOffset(Offset = "0x10")]
    public OInt Floor;
    [Token(Token = "0x400814F")]
    [FieldOffset(Offset = "0x24")]
    public OInt RankupNum;
    [Token(Token = "0x4008150")]
    [FieldOffset(Offset = "0x38")]
    public OInt WinNum;
    [Token(Token = "0x4008151")]
    [FieldOffset(Offset = "0x4C")]
    public OInt LoseNum;
    [Token(Token = "0x4008152")]
    [FieldOffset(Offset = "0x60")]
    public OInt BonusNum;
    [Token(Token = "0x4008153")]
    [FieldOffset(Offset = "0x74")]
    public OInt DownFloor;
    [Token(Token = "0x4008154")]
    [FieldOffset(Offset = "0x88")]
    public OInt ResetFloor;
    [Token(Token = "0x4008155")]
    [FieldOffset(Offset = "0x9C")]
    public OString[] WinIteminame;
    [Token(Token = "0x4008156")]
    [FieldOffset(Offset = "0xA0")]
    public VERSUS_ITEM_TYPE[] WinItemType;
    [Token(Token = "0x4008157")]
    [FieldOffset(Offset = "0xA4")]
    public OInt[] WinItemNum;
    [Token(Token = "0x4008158")]
    [FieldOffset(Offset = "0xA8")]
    public OString[] JoinIteminame;
    [Token(Token = "0x4008159")]
    [FieldOffset(Offset = "0xAC")]
    public VERSUS_ITEM_TYPE[] JoinItemType;
    [Token(Token = "0x400815A")]
    [FieldOffset(Offset = "0xB0")]
    public OInt[] JoinItemNum;
    [Token(Token = "0x400815B")]
    [FieldOffset(Offset = "0xB4")]
    public OString[] SpIteminame;
    [Token(Token = "0x400815C")]
    [FieldOffset(Offset = "0xB8")]
    public VERSUS_ITEM_TYPE[] SpItemType;
    [Token(Token = "0x400815D")]
    [FieldOffset(Offset = "0xBC")]
    public OInt[] SpItemnum;
    [Token(Token = "0x400815E")]
    [FieldOffset(Offset = "0xC0")]
    public OString[] SeasonIteminame;
    [Token(Token = "0x400815F")]
    [FieldOffset(Offset = "0xC4")]
    public VERSUS_ITEM_TYPE[] SeasonItemType;
    [Token(Token = "0x4008160")]
    [FieldOffset(Offset = "0xC8")]
    public OInt[] SeasonItemnum;
    [Token(Token = "0x4008161")]
    [FieldOffset(Offset = "0xCC")]
    public OString ArrivalIteminame;
    [Token(Token = "0x4008162")]
    [FieldOffset(Offset = "0xD0")]
    public VERSUS_ITEM_TYPE ArrivalItemType;
    [Token(Token = "0x4008163")]
    [FieldOffset(Offset = "0xD4")]
    public OInt ArrivalItemNum;

    [Token(Token = "0x6007E05")]
    [Address(RVA = "0x3FC370", Offset = "0x3FB170", VA = "0x103FC370")]
    public void Deserialize(JSON_VersusTowerParam json)
    {
    }

    [Token(Token = "0x6007E06")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusTowerParam()
    {
    }

    [Token(Token = "0x6007E07")]
    [Address(RVA = "0x3FCD10", Offset = "0x3FBB10", VA = "0x103FCD10")]
    static VersusTowerParam()
    {
    }
  }
}
