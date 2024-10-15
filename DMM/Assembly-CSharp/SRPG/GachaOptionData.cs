// Decompiled with JetBrains decompiler
// Type: SRPG.GachaOptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AF9")]
  [MessagePackObject(true)]
  public class GachaOptionData
  {
    [Token(Token = "0x40066AC")]
    [FieldOffset(Offset = "0x8")]
    private bool m_is_skip_animation;
    [Token(Token = "0x40066AD")]
    [FieldOffset(Offset = "0x9")]
    private bool m_auto_disassembly_rare2;
    [Token(Token = "0x40066AE")]
    [FieldOffset(Offset = "0xA")]
    private bool m_auto_disassembly_rare3;

    [Token(Token = "0x17000CD4")]
    public bool IsSkipAnimation
    {
      [Token(Token = "0x6006F4D"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CD5")]
    public bool IsAutoDisassemblyRare2
    {
      [Token(Token = "0x6006F4E"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CD6")]
    public bool IsAutoDisassemblyRare3
    {
      [Token(Token = "0x6006F4F"), Address(RVA = "0x34B070", Offset = "0x349E70", VA = "0x1034B070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006F50")]
    [Address(RVA = "0x368E40", Offset = "0x367C40", VA = "0x10368E40")]
    public void Deserialize(Json_GachaOption json)
    {
    }

    [Token(Token = "0x6006F51")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GachaOptionData()
    {
    }
  }
}
