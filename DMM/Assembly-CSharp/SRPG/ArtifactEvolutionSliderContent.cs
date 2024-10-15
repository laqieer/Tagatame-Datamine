// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactEvolutionSliderContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FE4")]
  public class ArtifactEvolutionSliderContent : MonoBehaviour
  {
    [Token(Token = "0x4008770")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Slider mSlider;
    [Token(Token = "0x4008771")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mUseNumText;
    [Token(Token = "0x4008772")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle mMaxToggle;
    [Token(Token = "0x4008773")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button mSliderAdd;
    [Token(Token = "0x4008774")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mSliderMinus;
    [Token(Token = "0x4008775")]
    [FieldOffset(Offset = "0x20")]
    private ItemData mItemData;

    [Token(Token = "0x170012D3")]
    public string ItemIname
    {
      [Token(Token = "0x600837E"), Address(RVA = "0x43EE70", Offset = "0x43DC70", VA = "0x1043EE70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170012D4")]
    public ItemData TargetItem
    {
      [Token(Token = "0x600837F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x170012D5")]
    public Slider SliderData
    {
      [Token(Token = "0x6008380"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Slider) null;
      }
    }

    [Token(Token = "0x170012D6")]
    public int SelectNum
    {
      [Token(Token = "0x6008381"), Address(RVA = "0x43EEA0", Offset = "0x43DCA0", VA = "0x1043EEA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170012D7")]
    public Toggle MaxToggle
    {
      [Token(Token = "0x6008382"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x6008383")]
    [Address(RVA = "0x43E910", Offset = "0x43D710", VA = "0x1043E910")]
    public void Init(ItemData item, int need_num)
    {
    }

    [Token(Token = "0x6008384")]
    [Address(RVA = "0x43EDD0", Offset = "0x43DBD0", VA = "0x1043EDD0")]
    public void UpdateUseNumTxt()
    {
    }

    [Token(Token = "0x6008385")]
    [Address(RVA = "0x43ECC0", Offset = "0x43DAC0", VA = "0x1043ECC0")]
    public void UpdateButtonIntaractable(int amount)
    {
    }

    [Token(Token = "0x6008386")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactEvolutionSliderContent()
    {
    }
  }
}
