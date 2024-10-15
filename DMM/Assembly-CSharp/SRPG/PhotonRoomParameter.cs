// Decompiled with JetBrains decompiler
// Type: SRPG.PhotonRoomParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200193F")]
  public class PhotonRoomParameter
  {
    [Token(Token = "0x4005B59")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4005B5A")]
    [FieldOffset(Offset = "0xC")]
    public int playerCount;
    [Token(Token = "0x4005B5B")]
    [FieldOffset(Offset = "0x10")]
    public int playerCountMax;
    [Token(Token = "0x4005B5C")]
    [FieldOffset(Offset = "0x14")]
    public bool open;
    [Token(Token = "0x4005B5D")]
    [FieldOffset(Offset = "0x15")]
    public bool start;
    [Token(Token = "0x4005B5E")]
    [FieldOffset(Offset = "0x16")]
    public bool battle;
    [Token(Token = "0x4005B5F")]
    [FieldOffset(Offset = "0x17")]
    public bool draft;
    [Token(Token = "0x4005B60")]
    [FieldOffset(Offset = "0x18")]
    public PhotonRoomData data;
    [Token(Token = "0x4005B61")]
    [FieldOffset(Offset = "0x1C")]
    public PhotonManager.LobbyType lobby;
    [Token(Token = "0x4005B62")]
    [FieldOffset(Offset = "0x20")]
    public int audience;
    [Token(Token = "0x4005B63")]
    [FieldOffset(Offset = "0x24")]
    public int audienceMax;
    [Token(Token = "0x4005B64")]
    [FieldOffset(Offset = "0x28")]
    public bool logger;

    [Token(Token = "0x600669B")]
    [Address(RVA = "0x32CD00", Offset = "0x32BB00", VA = "0x1032CD00")]
    public PhotonRoomParameter Clone() => (PhotonRoomParameter) null;

    [Token(Token = "0x600669C")]
    [Address(RVA = "0x32CDA0", Offset = "0x32BBA0", VA = "0x1032CDA0")]
    public PhotonRoomParameter()
    {
    }
  }
}
