// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestMissionsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C0A")]
  public class PointQuestMissionsData
  {
    [Token(Token = "0x4006CA3")]
    [FieldOffset(Offset = "0x8")]
    private EMissionType mType;
    [Token(Token = "0x4006CA4")]
    [FieldOffset(Offset = "0xC")]
    private string mVal;
    [Token(Token = "0x4006CA5")]
    [FieldOffset(Offset = "0x10")]
    private int mPoint;

    [Token(Token = "0x17000E6A")]
    public EMissionType Type
    {
      [Token(Token = "0x6007381"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new EMissionType();
      }
    }

    [Token(Token = "0x17000E6B")]
    public string Val
    {
      [Token(Token = "0x6007382"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E6C")]
    public int Point
    {
      [Token(Token = "0x6007383"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007384")]
    [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
    public void Deserialize(JSON_PointQuestMissionData json)
    {
    }

    [Token(Token = "0x6007385")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestMissionsData()
    {
    }
  }
}
