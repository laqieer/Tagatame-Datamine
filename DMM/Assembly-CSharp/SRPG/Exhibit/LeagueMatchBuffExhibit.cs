// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchBuffExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003451")]
  public class LeagueMatchBuffExhibit : BaseExhibit, IRenderModel<LeagueMatchBuffModel>, IRenderModel
  {
    [Token(Token = "0x400F80F")]
    [FieldOffset(Offset = "0x34")]
    private LeagueMatchBuffModel _model;
    [Token(Token = "0x400F810")]
    [FieldOffset(Offset = "0x38")]
    public Color UseCountDefaultColor;
    [Token(Token = "0x400F811")]
    [FieldOffset(Offset = "0x48")]
    public Color UseCountZeroColor;
    [Token(Token = "0x400F812")]
    [FieldOffset(Offset = "0x58")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchBuffExhibit.EKey), typeof (LeagueMatchBuffExhibit))]
    public string m_KeyName;

    [Token(Token = "0x1700216C")]
    public LeagueMatchBuffModel ModelData
    {
      [Token(Token = "0x600E966"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (LeagueMatchBuffModel) null;
      }
    }

    [Token(Token = "0x600E967")]
    [Address(RVA = "0xADEB70", Offset = "0xADD970", VA = "0x10ADEB70", Slot = "8")]
    public void Render(LeagueMatchBuffModel model)
    {
    }

    [Token(Token = "0x600E968")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchBuffExhibit()
    {
    }

    [Token(Token = "0x2003452")]
    private enum EKey
    {
      [Token(Token = "0x400F814")] None,
      [Token(Token = "0x400F815")] SetBuffData,
      [Token(Token = "0x400F816")] NotSetBuffData,
      [Token(Token = "0x400F817")] BuffImage,
      [Token(Token = "0x400F818")] BuffName,
      [Token(Token = "0x400F819")] BuffUseTitleObjActive,
      [Token(Token = "0x400F81A")] BuffUseNum,
      [Token(Token = "0x400F81B")] BuffUseNumMax,
      [Token(Token = "0x400F81C")] BuffDescription,
      [Token(Token = "0x400F81D")] BuffUseCount,
      [Token(Token = "0x400F81E")] DefaultBuffUseCount,
      [Token(Token = "0x400F81F")] UseCountColor,
      [Token(Token = "0x400F820")] BuffHide,
      [Token(Token = "0x400F821")] BuffHideObject,
      [Token(Token = "0x400F822")] ToggleObject,
      [Token(Token = "0x400F823")] BuffDisableMask,
      [Token(Token = "0x400F824")] SelectNumText,
    }
  }
}
