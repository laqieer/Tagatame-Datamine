// Decompiled with JetBrains decompiler
// Type: SRPG.PhotonPlayerParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001943")]
  [MessagePackObject(true)]
  public class PhotonPlayerParameter
  {
    [Token(Token = "0x4005B84")]
    [FieldOffset(Offset = "0x8")]
    public int photonPlayerID;
    [Token(Token = "0x4005B85")]
    [FieldOffset(Offset = "0xC")]
    public int resumeID;
    [Token(Token = "0x4005B86")]
    [FieldOffset(Offset = "0x10")]
    public PhotonPlayerData data;
    [Token(Token = "0x4005B87")]
    [FieldOffset(Offset = "0x14")]
    public bool start;

    [Token(Token = "0x17000A55")]
    public int PlayerId
    {
      [Token(Token = "0x60066A4"), Address(RVA = "0x32C140", Offset = "0x32AF40", VA = "0x1032C140")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066A5")]
    [Address(RVA = "0x32C0F0", Offset = "0x32AEF0", VA = "0x1032C0F0")]
    public bool IsEqual(PhotonPlayerParameter target) => new bool();

    [Token(Token = "0x60066A6")]
    [Address(RVA = "0x32C050", Offset = "0x32AE50", VA = "0x1032C050")]
    public PhotonPlayerParameter Clone() => (PhotonPlayerParameter) null;

    [Token(Token = "0x60066A7")]
    [Address(RVA = "0x32C120", Offset = "0x32AF20", VA = "0x1032C120")]
    public PhotonPlayerParameter()
    {
    }
  }
}
