// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePridePanelExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034D7")]
  public class RunePridePanelExhibit : BaseExhibit, IRenderModel<RunePridePanelModel>, IRenderModel
  {
    [Token(Token = "0x400FAB9")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePridePanelExhibit.EKey), typeof (RunePridePanelExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400FABA")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("スタートマス")]
    [CustomField("LV表示", CustomFieldAttribute.Type.UIText)]
    public Text startLvText;
    [Token(Token = "0x400FABB")]
    [FieldOffset(Offset = "0x3C")]
    [CustomGroup("ゴールマス")]
    [CustomField("LV表示", CustomFieldAttribute.Type.ImageArray)]
    public ImageArray goalLvImageArray;
    [Token(Token = "0x400FABC")]
    [FieldOffset(Offset = "0x40")]
    [CustomGroup("ゴールマス")]
    [CustomField("矢印", CustomFieldAttribute.Type.ImageArray)]
    public ImageArray goalKeyImageArray;
    [Token(Token = "0x400FABD")]
    [FieldOffset(Offset = "0x44")]
    [CustomField("フレーム", CustomFieldAttribute.Type.ImageArray)]
    [CustomGroup("ゴールマス")]
    public ImageArray goalFrameImageArray;
    [Token(Token = "0x400FABE")]
    [FieldOffset(Offset = "0x48")]
    [CustomField("ボタン", CustomFieldAttribute.Type.ImageArray)]
    [CustomGroup("複数選択モード")]
    public ImageArray selectMultipleButtonImageArray;
    [Token(Token = "0x400FABF")]
    [FieldOffset(Offset = "0x4C")]
    [CustomField("進捗", CustomFieldAttribute.Type.UIText)]
    [CustomGroup("ボーナス数進捗")]
    public Text currentPotentialNumText;
    [Token(Token = "0x400FAC0")]
    [FieldOffset(Offset = "0x50")]
    [CustomField("上限値", CustomFieldAttribute.Type.UIText)]
    [CustomGroup("ボーナス数進捗")]
    public Text maxPotentialNumText;

    [Token(Token = "0x600EA2D")]
    [Address(RVA = "0xAF2E20", Offset = "0xAF1C20", VA = "0x10AF2E20", Slot = "8")]
    public void Render(RunePridePanelModel model)
    {
    }

    [Token(Token = "0x600EA2E")]
    [Address(RVA = "0xAF3530", Offset = "0xAF2330", VA = "0x10AF3530")]
    private void SwitchCanSelectGoalSquare(bool isPanelCleared, bool canSelectGoalSquare)
    {
    }

    [Token(Token = "0x600EA2F")]
    [Address(RVA = "0xAF3550", Offset = "0xAF2350", VA = "0x10AF3550")]
    private void SwitchSelectMultipleMode(int imageIndex)
    {
    }

    [Token(Token = "0x600EA30")]
    [Address(RVA = "0xAF33C0", Offset = "0xAF21C0", VA = "0x10AF33C0")]
    private void SetPotentialNum(int current, int max)
    {
    }

    [Token(Token = "0x600EA31")]
    [Address(RVA = "0xAF34A0", Offset = "0xAF22A0", VA = "0x10AF34A0")]
    private void SetStartSquare(int startLv)
    {
    }

    [Token(Token = "0x600EA32")]
    [Address(RVA = "0xAF31D0", Offset = "0xAF1FD0", VA = "0x10AF31D0")]
    private void SetGoalSquare(
      int goalLvImageIndex,
      int goalSquareImageIndex,
      bool isPanelCleared,
      bool isLastLv)
    {
    }

    [Token(Token = "0x600EA33")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePridePanelExhibit()
    {
    }

    [Token(Token = "0x20034D8")]
    private enum EKey
    {
      [Token(Token = "0x400FAC2")] None,
      [Token(Token = "0x400FAC3")] StartSquare,
      [Token(Token = "0x400FAC4")] GoalSquare,
      [Token(Token = "0x400FAC5")] GoalButtonEnable,
      [Token(Token = "0x400FAC6")] SelectMultipleModeButtonImage,
      [Token(Token = "0x400FAC7")] PotentialNum,
    }
  }
}
