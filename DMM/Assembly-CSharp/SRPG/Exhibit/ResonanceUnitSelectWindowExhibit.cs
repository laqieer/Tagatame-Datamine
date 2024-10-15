// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ResonanceUnitSelectWindowExhibit
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
  [Token(Token = "0x200349D")]
  public class ResonanceUnitSelectWindowExhibit : 
    BaseExhibit,
    IRenderModel<ResonanceUnitSelectWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F9C9")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ResonanceUnitSelectWindowExhibit.EKey), typeof (ResonanceUnitSelectWindowExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F9CA")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("真理開眼の扉")]
    [CustomField("扉のオブジェクト", CustomFieldAttribute.Type.GameObject)]
    public GameObject TobiraTemplate;
    [Token(Token = "0x400F9CB")]
    [FieldOffset(Offset = "0x3C")]
    public ExhibitList IconExhibitList;
    [Token(Token = "0x400F9CC")]
    [FieldOffset(Offset = "0x40")]
    public SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400F9CD")]
    [FieldOffset(Offset = "0x44")]
    private List<ExhibitList> mTobiraList;

    [Token(Token = "0x600E9D7")]
    [Address(RVA = "0xAEEDC0", Offset = "0xAEDBC0", VA = "0x10AEEDC0", Slot = "8")]
    public void Render(ResonanceUnitSelectWindowModel model)
    {
    }

    [Token(Token = "0x600E9D8")]
    [Address(RVA = "0xAEEFA0", Offset = "0xAEDDA0", VA = "0x10AEEFA0")]
    private void SetIcon(ResonanceUnitSelectWindowModel model)
    {
    }

    [Token(Token = "0x600E9D9")]
    [Address(RVA = "0xAEF130", Offset = "0xAEDF30", VA = "0x10AEF130")]
    private void SetTobira(ResonanceUnitSelectWindowModel model)
    {
    }

    [Token(Token = "0x600E9DA")]
    [Address(RVA = "0xAEECA0", Offset = "0xAEDAA0", VA = "0x10AEECA0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600E9DB")]
    [Address(RVA = "0xAEF430", Offset = "0xAEE230", VA = "0x10AEF430")]
    public ResonanceUnitSelectWindowExhibit()
    {
    }

    [Token(Token = "0x200349E")]
    private enum EKey
    {
      [Token(Token = "0x400F9CF"), CustomEnumDesc("未設定")] None,
      [Token(Token = "0x400F9D0"), CustomEnumDesc("アイコン")] Icon,
      [Token(Token = "0x400F9D1"), CustomEnumDesc("未設定")] Tobira,
      [Token(Token = "0x400F9D2"), CustomEnumDesc("共鳴済みの際表示")] Resonance,
      [Token(Token = "0x400F9D3"), CustomEnumDesc("共鳴不可ときに表示")] InvalidResonance,
      [Token(Token = "0x400F9D4"), CustomEnumDesc("共鳴不可の時の説明テキスト")] InvalidResonanceMsg,
    }
  }
}
