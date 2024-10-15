// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideResetPotentialStatusPriorityChild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A4C")]
  [FlowNode.Pin(1, "SE有効化", FlowNode.PinTypes.Input, 1)]
  public class RunePrideResetPotentialStatusPriorityChild : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CDC5")]
    private const int PIN_INPUT_SOUND_INIT = 1;
    [Token(Token = "0x400CDC6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mTogglePriority;
    [Token(Token = "0x400CDC7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mImageArray;
    [Token(Token = "0x400CDC8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CDC9")]
    [FieldOffset(Offset = "0x18")]
    private UnityAction<bool> mOnValueChanged;
    [Token(Token = "0x400CDCA")]
    [FieldOffset(Offset = "0x1C")]
    private int mPriority;
    [Token(Token = "0x400CDCB")]
    [FieldOffset(Offset = "0x20")]
    private int mUseCount;
    [Token(Token = "0x400CDCC")]
    [FieldOffset(Offset = "0x24")]
    private int mNeedItemCount;
    [Token(Token = "0x400CDCD")]
    [FieldOffset(Offset = "0x28")]
    private bool mAwakened;
    [Token(Token = "0x400CDCE")]
    [FieldOffset(Offset = "0x2C")]
    private string mItemIname;
    [Token(Token = "0x400CDCF")]
    [FieldOffset(Offset = "0x30")]
    private RunePrideResetPotentialStatusPriorityChildModel mModel;

    [Token(Token = "0x170019D4")]
    public string Iname
    {
      [Token(Token = "0x600C0E5"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170019D5")]
    public int Priority
    {
      [Token(Token = "0x600C0E6"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170019D6")]
    public bool IsOn
    {
      [Token(Token = "0x600C0E7"), Address(RVA = "0x894A90", Offset = "0x893890", VA = "0x10894A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C0E8")]
    [Address(RVA = "0x894500", Offset = "0x893300", VA = "0x10894500", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C0E9")]
    [Address(RVA = "0x500530", Offset = "0x4FF330", VA = "0x10500530")]
    private void Awake()
    {
    }

    [Token(Token = "0x170019D7")]
    public int HaveCount
    {
      [Token(Token = "0x600C0EA"), Address(RVA = "0x8949E0", Offset = "0x8937E0", VA = "0x108949E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C0EB")]
    [Address(RVA = "0x894870", Offset = "0x893670", VA = "0x10894870")]
    public void SetUseCount(int use_count)
    {
    }

    [Token(Token = "0x600C0EC")]
    [Address(RVA = "0x894890", Offset = "0x893690", VA = "0x10894890")]
    public void Setup(
      string item_iname,
      UnityAction<bool> onValueChanged,
      int need_count,
      int use_count = 1)
    {
    }

    [Token(Token = "0x600C0ED")]
    [Address(RVA = "0x894520", Offset = "0x893320", VA = "0x10894520")]
    public void OnValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x600C0EE")]
    [Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")]
    public void SetPriority(int priority)
    {
    }

    [Token(Token = "0x600C0EF")]
    [Address(RVA = "0x8947F0", Offset = "0x8935F0", VA = "0x108947F0")]
    public void SetToggle(bool isOn)
    {
    }

    [Token(Token = "0x600C0F0")]
    [Address(RVA = "0x8946A0", Offset = "0x8934A0", VA = "0x108946A0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C0F1")]
    [Address(RVA = "0x8949C0", Offset = "0x8937C0", VA = "0x108949C0")]
    public RunePrideResetPotentialStatusPriorityChild()
    {
    }
  }
}
