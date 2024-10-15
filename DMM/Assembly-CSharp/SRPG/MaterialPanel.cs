// Decompiled with JetBrains decompiler
// Type: SRPG.MaterialPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200271F")]
  [AddComponentMenu("UI/MaterialPanel")]
  public class MaterialPanel : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x400B84D")]
    [FieldOffset(Offset = "0xC")]
    public Text Num;
    [Token(Token = "0x400B84E")]
    [FieldOffset(Offset = "0x10")]
    public Text Req;
    [Token(Token = "0x400B84F")]
    [FieldOffset(Offset = "0x14")]
    public Text Left;
    [Token(Token = "0x400B850")]
    [FieldOffset(Offset = "0x18")]
    public Slider Slider;
    [Token(Token = "0x400B851")]
    [FieldOffset(Offset = "0x1C")]
    public string State;
    [Token(Token = "0x400B852")]
    [FieldOffset(Offset = "0x20")]
    private ItemParam mItemParam;
    [Token(Token = "0x400B853")]
    [FieldOffset(Offset = "0x24")]
    private int mReqNum;
    [Token(Token = "0x400B854")]
    [FieldOffset(Offset = "0x28")]
    private int mHasNum;

    [Token(Token = "0x600AF6A")]
    [Address(RVA = "0x738840", Offset = "0x737640", VA = "0x10738840")]
    public void SetMaterial(int reqNum, ItemParam material)
    {
    }

    [Token(Token = "0x600AF6B")]
    [Address(RVA = "0x738930", Offset = "0x737730", VA = "0x10738930", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600AF6C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MaterialPanel()
    {
    }
  }
}
