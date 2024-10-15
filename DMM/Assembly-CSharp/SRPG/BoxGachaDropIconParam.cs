// Decompiled with JetBrains decompiler
// Type: SRPG.BoxGachaDropIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002106")]
  public class BoxGachaDropIconParam : ContentSource.Param
  {
    [Token(Token = "0x4008F21")]
    [FieldOffset(Offset = "0x10")]
    private BoxGachaDropIconNode mNode;

    [Token(Token = "0x1700139C")]
    public GenesisRewardDataParam reward
    {
      [Token(Token = "0x6008A25"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (GenesisRewardDataParam) null;
      }
      [Token(Token = "0x6008A26"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x1700139D")]
    public string anim_trigger
    {
      [Token(Token = "0x6008A27"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008A28"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x1700139E")]
    public string skip_trigger
    {
      [Token(Token = "0x6008A29"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008A2A"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x1700139F")]
    public string disable_trigger
    {
      [Token(Token = "0x6008A2B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008A2C"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170013A0")]
    public bool is_animed
    {
      [Token(Token = "0x6008A2D"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008A2E"), Address(RVA = "0x2A5AD0", Offset = "0x2A48D0", VA = "0x102A5AD0")] set
      {
      }
    }

    [Token(Token = "0x6008A2F")]
    [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
    public ContentNode GetNode() => (ContentNode) null;

    [Token(Token = "0x170013A1")]
    public Animator animator
    {
      [Token(Token = "0x6008A30"), Address(RVA = "0x4A54E0", Offset = "0x4A42E0", VA = "0x104A54E0")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x6008A31")]
    [Address(RVA = "0x4A51D0", Offset = "0x4A3FD0", VA = "0x104A51D0", Slot = "11")]
    public override void OnSetup(ContentNode node)
    {
    }

    [Token(Token = "0x6008A32")]
    [Address(RVA = "0x4A5160", Offset = "0x4A3F60", VA = "0x104A5160", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x6008A33")]
    [Address(RVA = "0x4A5130", Offset = "0x4A3F30", VA = "0x104A5130", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x6008A34")]
    [Address(RVA = "0x4A5240", Offset = "0x4A4040", VA = "0x104A5240", Slot = "14")]
    public override void OnViewIn(ContentNode node, Vector2 pivotViewPosition)
    {
    }

    [Token(Token = "0x6008A35")]
    [Address(RVA = "0x4A5280", Offset = "0x4A4080", VA = "0x104A5280", Slot = "15")]
    public override void OnViewOut(ContentNode node, Vector2 pivotViewPosition)
    {
    }

    [Token(Token = "0x6008A36")]
    [Address(RVA = "0x4A52E0", Offset = "0x4A40E0", VA = "0x104A52E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008A37")]
    [Address(RVA = "0x4A52C0", Offset = "0x4A40C0", VA = "0x104A52C0")]
    public void PlayAnim()
    {
    }

    [Token(Token = "0x6008A38")]
    [Address(RVA = "0x4A54C0", Offset = "0x4A42C0", VA = "0x104A54C0")]
    public void SkipAnim()
    {
    }

    [Token(Token = "0x6008A39")]
    [Address(RVA = "0x4A5110", Offset = "0x4A3F10", VA = "0x104A5110")]
    public void DisableAnim()
    {
    }

    [Token(Token = "0x6008A3A")]
    [Address(RVA = "0x4A53F0", Offset = "0x4A41F0", VA = "0x104A53F0")]
    public void SetAnimTrigger(string trigger)
    {
    }

    [Token(Token = "0x6008A3B")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public BoxGachaDropIconParam()
    {
    }
  }
}
