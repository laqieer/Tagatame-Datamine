// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.MasteryRewardExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003477")]
  public class MasteryRewardExhibit : BaseExhibit, IRenderModel<MasteryRewardModel>, IRenderModel
  {
    [Token(Token = "0x400F8F1")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (MasteryRewardExhibit.EKey), typeof (MasteryRewardExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F8F2")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("コピー先", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("拡張")]
    public GameObject m_Parent;
    [Token(Token = "0x400F8F3")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("コピー元", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("拡張")]
    public GameObject m_CopyObject;

    [Token(Token = "0x600E99A")]
    [Address(RVA = "0xAE3AC0", Offset = "0xAE28C0", VA = "0x10AE3AC0", Slot = "8")]
    public void Render(MasteryRewardModel model)
    {
    }

    [Token(Token = "0x600E99B")]
    [Address(RVA = "0xAE36B0", Offset = "0xAE24B0", VA = "0x10AE36B0")]
    private void CopyObject(List<MasteryRewardData> masteryRewardDataList)
    {
    }

    [Token(Token = "0x600E99C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardExhibit()
    {
    }

    [Token(Token = "0x2003478")]
    private enum EKey
    {
      [Token(Token = "0x400F8F5")] None,
      [Token(Token = "0x400F8F6")] NOW_EMBLEM,
      [Token(Token = "0x400F8F7")] NOW_TEXT,
      [Token(Token = "0x400F8F8")] NEXT_TEXT,
      [Token(Token = "0x400F8F9")] NEXT_MAX,
      [Token(Token = "0x400F8FA")] NEXT_BAR,
      [Token(Token = "0x400F8FB")] REWARD_LIST,
      [Token(Token = "0x400F8FC")] SET_BUTTON,
    }
  }
}
