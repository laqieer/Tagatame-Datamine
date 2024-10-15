// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePridePanelSquareExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034D9")]
  public class RunePridePanelSquareExhibit : 
    BaseExhibit,
    IRenderModel<RunePridePanelSquareModel>,
    IRenderModel
  {
    [Token(Token = "0x400FAC8")]
    private const int INDEX_OFF = 0;
    [Token(Token = "0x400FAC9")]
    private const int INDEX_ON = 1;
    [Token(Token = "0x400FACA")]
    private const int STAR_MASK = 2;
    [Token(Token = "0x400FACB")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePridePanelSquareExhibit.EKey), typeof (RunePridePanelSquareExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400FACC")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("マス背景画像", CustomFieldAttribute.Type.ImageArray)]
    [CustomGroup("通常マス未開放、通常マス開放済、特殊マス未開放、特殊マス開放済みの順で指定")]
    public ImageArray backgroundImage;
    [Token(Token = "0x400FACD")]
    [FieldOffset(Offset = "0x3C")]
    [CustomGroup("マスが解放されたときに表示するラインオブジェクト")]
    [CustomField("マスIDが若い順に指定", CustomFieldAttribute.Type.Array)]
    public GameObject[] releaseLineObjects;
    [Token(Token = "0x400FACE")]
    [FieldOffset(Offset = "0x40")]
    [CustomGroup("パラメータアイコン ")]
    [CustomField("Image", CustomFieldAttribute.Type.UIImage)]
    public Image parameterIcon;
    [Token(Token = "0x400FACF")]
    [FieldOffset(Offset = "0x44")]
    [CustomGroup("上昇値テキスト")]
    [CustomField("通常マス未開放", CustomFieldAttribute.Type.UIText)]
    public Text parameterTextNormalOff;
    [Token(Token = "0x400FAD0")]
    [FieldOffset(Offset = "0x48")]
    [CustomGroup("上昇値テキスト")]
    [CustomField("通常マス開放済", CustomFieldAttribute.Type.UIText)]
    public Text parameterTextNormalOn;
    [Token(Token = "0x400FAD1")]
    [FieldOffset(Offset = "0x4C")]
    [CustomGroup("上昇値テキスト")]
    [CustomField("特殊マス未開放", CustomFieldAttribute.Type.UIText)]
    public Text parameterTextPotentialOff;
    [Token(Token = "0x400FAD2")]
    [FieldOffset(Offset = "0x50")]
    [CustomGroup("上昇値テキスト")]
    [CustomField("特殊マス開放済", CustomFieldAttribute.Type.UIText)]
    public Text parameterTextPotentialOn;
    [Token(Token = "0x400FAD3")]
    [FieldOffset(Offset = "0x54")]
    private Text[] parameterTexts;
    [Token(Token = "0x400FAD4")]
    [FieldOffset(Offset = "0x58")]
    [CustomField("", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("選択可能なマスに表示するオブジェクト")]
    public GameObject canSelectObject;
    [Token(Token = "0x400FAD5")]
    [FieldOffset(Offset = "0x5C")]
    [CustomGroup("選択中のマスに表示するオブジェクト")]
    [CustomField("", CustomFieldAttribute.Type.GameObject)]
    public GameObject selectedObject;
    [Token(Token = "0x400FAD6")]
    [FieldOffset(Offset = "0x60")]
    [CustomGroup("同分岐グループ別ルート確定済みor獲得上限を超過する★の数が設定されている特殊マスのときに表示するマスク")]
    [CustomField("", CustomFieldAttribute.Type.GameObject)]
    public GameObject anotherRouteFixedObject;
    [Token(Token = "0x400FAD7")]
    [FieldOffset(Offset = "0x64")]
    private List<ImageArray> stars;
    [Token(Token = "0x400FAD8")]
    [FieldOffset(Offset = "0x68")]
    [CustomGroup("ボーナス表示")]
    [CustomField("★のオブジェクトの親オブジェクト", CustomFieldAttribute.Type.GameObject)]
    public GameObject potentialStarParent;
    [Token(Token = "0x400FAD9")]
    [FieldOffset(Offset = "0x6C")]
    [CustomField("★オブジェクト", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("ボーナス表示")]
    public GameObject potentialStarObj;
    [Token(Token = "0x400FADA")]
    [FieldOffset(Offset = "0x70")]
    [CustomField("", CustomFieldAttribute.Type.UIButton)]
    [CustomGroup("ボタンの有効無効切替")]
    public Button button;
    [Token(Token = "0x400FADB")]
    [FieldOffset(Offset = "0x74")]
    [CustomGroup("解放済みのマスに表示するオブジェクト")]
    [CustomField("", CustomFieldAttribute.Type.GameObject)]
    public GameObject releasedObject;
    [Token(Token = "0x400FADC")]
    [FieldOffset(Offset = "0x78")]
    [CustomGroup("ボタンの有効無効切替を別途作成")]
    [CustomField("", CustomFieldAttribute.Type.UIButton)]
    public Button intractableButton;
    [Token(Token = "0x400FADD")]
    [FieldOffset(Offset = "0x7C")]
    [CustomField("", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("解放済みのマスを選択中に表示するオブジェクト")]
    public GameObject releasedSquareSelectedObject;

    [Token(Token = "0x600EA34")]
    [Address(RVA = "0xAF3610", Offset = "0xAF2410", VA = "0x10AF3610", Slot = "8")]
    public void Render(RunePridePanelSquareModel model)
    {
    }

    [Token(Token = "0x600EA35")]
    [Address(RVA = "0xAF3C30", Offset = "0xAF2A30", VA = "0x10AF3C30")]
    private void SetBackground(int activateIndex)
    {
    }

    [Token(Token = "0x600EA36")]
    [Address(RVA = "0xAF3D00", Offset = "0xAF2B00", VA = "0x10AF3D00")]
    private void SetLineObjects(int activateIndex)
    {
    }

    [Token(Token = "0x600EA37")]
    [Address(RVA = "0xAF3DA0", Offset = "0xAF2BA0", VA = "0x10AF3DA0")]
    private void SetParameterIcon(bool isReleased, Sprite on, Sprite off)
    {
    }

    [Token(Token = "0x600EA38")]
    [Address(RVA = "0xAF3E30", Offset = "0xAF2C30", VA = "0x10AF3E30")]
    private void SetParameterText(int upValue, int activateIndex)
    {
    }

    [Token(Token = "0x600EA39")]
    [Address(RVA = "0xAF3B60", Offset = "0xAF2960", VA = "0x10AF3B60")]
    private void SetActiveParamterText(int activateIndex)
    {
    }

    [Token(Token = "0x600EA3A")]
    [Address(RVA = "0xAF44E0", Offset = "0xAF32E0", VA = "0x10AF44E0")]
    private void SetSelectable(bool isPlayAnimation)
    {
    }

    [Token(Token = "0x600EA3B")]
    [Address(RVA = "0xAF3CB0", Offset = "0xAF2AB0", VA = "0x10AF3CB0")]
    private void SetCursor(bool isSelect)
    {
    }

    [Token(Token = "0x600EA3C")]
    [Address(RVA = "0xAF4530", Offset = "0xAF3330", VA = "0x10AF4530")]
    private void SetSquareMask(bool isMask)
    {
    }

    [Token(Token = "0x600EA3D")]
    [Address(RVA = "0xAF4150", Offset = "0xAF2F50", VA = "0x10AF4150")]
    private void SetPotentialStar(
      int potentialNum,
      bool isPotential,
      bool isReleased,
      bool isMask)
    {
    }

    [Token(Token = "0x600EA3E")]
    [Address(RVA = "0xAF3C60", Offset = "0xAF2A60", VA = "0x10AF3C60")]
    private void SetButtonInteractable(bool isInteractable)
    {
    }

    [Token(Token = "0x600EA3F")]
    [Address(RVA = "0xAF4490", Offset = "0xAF3290", VA = "0x10AF4490")]
    private void SetReleasedSquare(bool isReleased)
    {
    }

    [Token(Token = "0x600EA40")]
    [Address(RVA = "0xAF4440", Offset = "0xAF3240", VA = "0x10AF4440")]
    private void SetReleasedSquareSelected(bool isActive)
    {
    }

    [Token(Token = "0x600EA41")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePridePanelSquareExhibit()
    {
    }

    [Token(Token = "0x20034DA")]
    private enum EKey
    {
      [Token(Token = "0x400FADF")] None,
      [Token(Token = "0x400FAE0")] Background,
      [Token(Token = "0x400FAE1")] LineObjects,
      [Token(Token = "0x400FAE2")] ParameterIcon,
      [Token(Token = "0x400FAE3")] ParameterText,
      [Token(Token = "0x400FAE4")] CanReleaseAnimataion,
      [Token(Token = "0x400FAE5")] SelectCursor,
      [Token(Token = "0x400FAE6")] AnotherRouteMask,
      [Token(Token = "0x400FAE7")] PotentialStar,
      [Token(Token = "0x400FAE8")] ButtonEnable,
      [Token(Token = "0x400FAE9")] ReleasedSquare,
      [Token(Token = "0x400FAEA")] ReleasedSquareSelected,
    }
  }
}
