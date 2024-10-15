// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDisassemblySettingStatusExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034AF")]
  public class RuneDisassemblySettingStatusExhibit : 
    BaseExhibit,
    IRenderModel<RuneDisassemblySettingStatusModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA1B")]
    [FieldOffset(Offset = "0x34")]
    private RuneDisassemblySettingStatusModel _model;
    [Token(Token = "0x400FA1C")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDisassemblySettingStatusExhibit.EKey), typeof (RuneDisassemblySettingStatusExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400FA1D")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("スライダー変更時のテキスト", CustomFieldAttribute.Type.UIText)]
    [CustomGroup("スライダー")]
    public Text m_Slider_Text;
    [Token(Token = "0x400FA1E")]
    [FieldOffset(Offset = "0x40")]
    [CustomField("+ボタン", CustomFieldAttribute.Type.UIButton)]
    [CustomGroup("隠す用")]
    public Button m_Slider_Plus;
    [Token(Token = "0x400FA1F")]
    [FieldOffset(Offset = "0x44")]
    [CustomField("-ボタン", CustomFieldAttribute.Type.UIButton)]
    [CustomGroup("隠す用")]
    public Button m_Slider_Minus;
    [Token(Token = "0x400FA20")]
    [FieldOffset(Offset = "0x48")]
    [CustomField("スライダーマスク", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("隠す用")]
    public GameObject m_Slider_Mask;
    [Token(Token = "0x400FA21")]
    [FieldOffset(Offset = "0x4C")]
    [CustomGroup("隠す用")]
    [CustomField("有効にする文言", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_Text_off;
    [Token(Token = "0x400FA22")]
    [FieldOffset(Offset = "0x50")]
    [CustomGroup("隠す用")]
    [CustomField("有効にするCanvasGroup", CustomFieldAttribute.Type.Component, typeof (CanvasGroup), null)]
    public CanvasGroup m_CanvasGroup;

    [Token(Token = "0x17002170")]
    public RuneDisassemblySettingStatusModel ModelData
    {
      [Token(Token = "0x600E9F8"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (RuneDisassemblySettingStatusModel) null;
      }
    }

    [Token(Token = "0x600E9F9")]
    [Address(RVA = "0xAF1650", Offset = "0xAF0450", VA = "0x10AF1650", Slot = "8")]
    public void Render(RuneDisassemblySettingStatusModel model)
    {
    }

    [Token(Token = "0x600E9FA")]
    [Address(RVA = "0xAF14C0", Offset = "0xAF02C0", VA = "0x10AF14C0")]
    private void OnValueChanged(float value)
    {
    }

    [Token(Token = "0x600E9FB")]
    [Address(RVA = "0xAF1970", Offset = "0xAF0770", VA = "0x10AF1970")]
    private void SetSliderGroup(bool isValue)
    {
    }

    [Token(Token = "0x600E9FC")]
    [Address(RVA = "0xAF15D0", Offset = "0xAF03D0", VA = "0x10AF15D0")]
    private void RemoveSliderListener()
    {
    }

    [Token(Token = "0x600E9FD")]
    [Address(RVA = "0xAF14B0", Offset = "0xAF02B0", VA = "0x10AF14B0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600E9FE")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDisassemblySettingStatusExhibit()
    {
    }

    [Token(Token = "0x20034B0")]
    private enum EKey
    {
      [Token(Token = "0x400FA24")] None,
      [Token(Token = "0x400FA25")] Name,
      [Token(Token = "0x400FA26")] Number,
      [Token(Token = "0x400FA27")] Message,
      [Token(Token = "0x400FA28")] Slider,
      [Token(Token = "0x400FA29")] Checkbox,
      [Token(Token = "0x400FA2A")] Hide,
    }
  }
}
