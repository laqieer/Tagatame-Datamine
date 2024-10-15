// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021E9")]
  [AddComponentMenu("UI/ConceptCardDetailBase")]
  public class ConceptCardDetailBase : MonoBehaviour
  {
    [Token(Token = "0x400952A")]
    [FieldOffset(Offset = "0xC")]
    protected ConceptCardData mConceptCardData;

    [Token(Token = "0x1700143B")]
    protected GameManager GM
    {
      [Token(Token = "0x6008F4C"), Address(RVA = "0x526BC0", Offset = "0x5259C0", VA = "0x10526BC0")] get
      {
        return (GameManager) null;
      }
    }

    [Token(Token = "0x1700143C")]
    protected MasterParam Master
    {
      [Token(Token = "0x6008F4D"), Address(RVA = "0x526BF0", Offset = "0x5259F0", VA = "0x10526BF0")] get
      {
        return (MasterParam) null;
      }
    }

    [Token(Token = "0x6008F4E")]
    [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130", Slot = "4")]
    public virtual void SetParam(ConceptCardData card_data)
    {
    }

    [Token(Token = "0x6008F4F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public virtual void SetParam(
      ConceptCardData card_data,
      int addExp,
      int addTrust,
      int addAwakeLv)
    {
    }

    [Token(Token = "0x6008F50")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public virtual void SetParam(
      ConceptCardData card_data,
      int addExp,
      int addTrust,
      int addAwakeLv,
      bool isExtra)
    {
    }

    [Token(Token = "0x6008F51")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    public virtual void Refresh()
    {
    }

    [Token(Token = "0x6008F52")]
    [Address(RVA = "0x526AA0", Offset = "0x5258A0", VA = "0x10526AA0")]
    public void SetText(Text text, string str)
    {
    }

    [Token(Token = "0x6008F53")]
    [Address(RVA = "0x526950", Offset = "0x525750", VA = "0x10526950")]
    public void LoadImage(string path, RawImage image)
    {
    }

    [Token(Token = "0x6008F54")]
    [Address(RVA = "0x526B10", Offset = "0x525910", VA = "0x10526B10")]
    public void SwitchObject(bool is_on, GameObject obj, GameObject opposite_obj)
    {
    }

    [Token(Token = "0x6008F55")]
    [Address(RVA = "0x526A30", Offset = "0x525830", VA = "0x10526A30")]
    public void SetSprite(Image image, Sprite sprite)
    {
    }

    [Token(Token = "0x6008F56")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardDetailBase()
    {
    }
  }
}
