// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CountAnimationExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033F3")]
  public class CountAnimationExhibit : BaseExhibit, IRenderModel<CountAnimationModel>, IRenderModel
  {
    [Token(Token = "0x400F654")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CountAnimationExhibit.EKey), typeof (CountAnimationExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8C9")]
    [Address(RVA = "0xAD8D70", Offset = "0xAD7B70", VA = "0x10AD8D70", Slot = "8")]
    public void Render(CountAnimationModel model)
    {
    }

    [Token(Token = "0x600E8CA")]
    [Address(RVA = "0xAD8D00", Offset = "0xAD7B00", VA = "0x10AD8D00")]
    private IEnumerator CountUpAnimation(CountAnimationModel model) => (IEnumerator) null;

    [Token(Token = "0x600E8CB")]
    [Address(RVA = "0xAD8C90", Offset = "0xAD7A90", VA = "0x10AD8C90")]
    private IEnumerator CountDownAnimation(CountAnimationModel model) => (IEnumerator) null;

    [Token(Token = "0x600E8CC")]
    [Address(RVA = "0xAD8BA0", Offset = "0xAD79A0", VA = "0x10AD8BA0")]
    private void ConvertSetText(CountAnimationModel model, float num)
    {
    }

    [Token(Token = "0x600E8CD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CountAnimationExhibit()
    {
    }

    [Token(Token = "0x20033F4")]
    private enum EKey
    {
      [Token(Token = "0x400F656")] None,
      [Token(Token = "0x400F657")] CountUp,
      [Token(Token = "0x400F658")] CountDown,
    }
  }
}
