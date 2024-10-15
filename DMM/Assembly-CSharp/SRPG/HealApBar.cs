// Decompiled with JetBrains decompiler
// Type: SRPG.HealApBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002616")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("UI/HealApBar")]
  public class HealApBar : MonoBehaviour
  {
    [Token(Token = "0x400B15C")]
    [FieldOffset(Offset = "0xC")]
    public Slider slider;
    [Token(Token = "0x400B15D")]
    [FieldOffset(Offset = "0x10")]
    public int UseItemNum;
    [Token(Token = "0x400B15E")]
    [FieldOffset(Offset = "0x14")]
    public GameObject HealApBase;
    [Token(Token = "0x400B15F")]
    [FieldOffset(Offset = "0x18")]
    public Text Num;
    [Token(Token = "0x400B160")]
    [FieldOffset(Offset = "0x1C")]
    public Text HealApNum;
    [Token(Token = "0x400B161")]
    [FieldOffset(Offset = "0x20")]
    public Text ItemName;
    [Token(Token = "0x400B162")]
    [FieldOffset(Offset = "0x24")]
    public Text ItemCheckUse;
    [Token(Token = "0x400B163")]
    [FieldOffset(Offset = "0x28")]
    private ItemData mData;
    [Token(Token = "0x400B164")]
    [FieldOffset(Offset = "0x2C")]
    public Button up_button;
    [Token(Token = "0x400B165")]
    [FieldOffset(Offset = "0x30")]
    public Button down_button;
    [Token(Token = "0x400B166")]
    [FieldOffset(Offset = "0x34")]
    public Text CurrentAP;

    [Token(Token = "0x170017E1")]
    public int HealNum
    {
      [Token(Token = "0x600A9D0"), Address(RVA = "0x6D08E0", Offset = "0x6CF6E0", VA = "0x106D08E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170017E2")]
    public bool IsOverFlow
    {
      [Token(Token = "0x600A9D1"), Address(RVA = "0x6D0910", Offset = "0x6CF710", VA = "0x106D0910")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A9D2")]
    [Address(RVA = "0x6D01C0", Offset = "0x6CEFC0", VA = "0x106D01C0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600A9D3")]
    [Address(RVA = "0x6D0380", Offset = "0x6CF180", VA = "0x106D0380")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A9D4")]
    [Address(RVA = "0x6D0110", Offset = "0x6CEF10", VA = "0x106D0110")]
    public int GetMaxNum() => new int();

    [Token(Token = "0x600A9D5")]
    [Address(RVA = "0x6D02D0", Offset = "0x6CF0D0", VA = "0x106D02D0")]
    public void OnValueChanged(float value)
    {
    }

    [Token(Token = "0x600A9D6")]
    [Address(RVA = "0x6D08B0", Offset = "0x6CF6B0", VA = "0x106D08B0")]
    public void Up()
    {
    }

    [Token(Token = "0x600A9D7")]
    [Address(RVA = "0x6D00E0", Offset = "0x6CEEE0", VA = "0x106D00E0")]
    public void Down()
    {
    }

    [Token(Token = "0x600A9D8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HealApBar()
    {
    }
  }
}
