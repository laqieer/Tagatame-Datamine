// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEquipDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002204")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "更新終了", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/ConceptCardEquipDetail")]
  public class ConceptCardEquipDetail : MonoBehaviour
  {
    [Token(Token = "0x40095EB")]
    public const int PIN_REFRESH = 0;
    [Token(Token = "0x40095EC")]
    public const int PIN_REFRESH_END = 10;
    [Token(Token = "0x40095ED")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼ConceptCardDescriptionの参照方式")]
    [SerializeField]
    private ConceptCardEquipDetail.DescriptionInstanceType m_DescriptionInstanceType;
    [Token(Token = "0x40095EE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ConceptCardDescription mConceptCardDescription;
    [Token(Token = "0x40095EF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [HeaderBar("▼複製したConceptCardDescriptionを入れる親")]
    private RectTransform mConceptCardDescriptionRoot;
    [Token(Token = "0x40095F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mConceptCardIconRoot;
    [Token(Token = "0x40095F1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mCardNameText;
    [Token(Token = "0x40095F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ConceptCardIcon mConceptCardIcon;
    [Token(Token = "0x40095F3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mConceptCardNum;
    [Token(Token = "0x40095F4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int mConceptCardNumDigits;
    [Token(Token = "0x40095F5")]
    [FieldOffset(Offset = "0x2C")]
    private ConceptCardData mConceptCardData;
    [Token(Token = "0x40095F6")]
    [FieldOffset(Offset = "0x30")]
    private UnitData mUnitData;
    [Token(Token = "0x40095F7")]
    [FieldOffset(Offset = "0x0")]
    private static UnitData s_UnitData;
    [Token(Token = "0x40095F8")]
    [FieldOffset(Offset = "0x4")]
    private static int s_SelectedSlotIndex;

    [Token(Token = "0x6008FEF")]
    [Address(RVA = "0x52E770", Offset = "0x52D570", VA = "0x1052E770")]
    public static void SetSelectedUnitData(UnitData mUnitData, int selectedSlotIndex)
    {
    }

    [Token(Token = "0x6008FF0")]
    [Address(RVA = "0x52E7C0", Offset = "0x52D5C0", VA = "0x1052E7C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008FF1")]
    [Address(RVA = "0x52E5E0", Offset = "0x52D3E0", VA = "0x1052E5E0")]
    public void SetParam()
    {
    }

    [Token(Token = "0x6008FF2")]
    [Address(RVA = "0x52E390", Offset = "0x52D190", VA = "0x1052E390")]
    private bool CheckGetUnitFrame() => new bool();

    [Token(Token = "0x6008FF3")]
    [Address(RVA = "0x52E470", Offset = "0x52D270", VA = "0x1052E470")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008FF4")]
    [Address(RVA = "0x52E420", Offset = "0x52D220", VA = "0x1052E420")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008FF5")]
    [Address(RVA = "0x52E9D0", Offset = "0x52D7D0", VA = "0x1052E9D0")]
    public ConceptCardEquipDetail()
    {
    }

    [Token(Token = "0x2002205")]
    private enum DescriptionInstanceType
    {
      [Token(Token = "0x40095FA")] DirectUse,
      [Token(Token = "0x40095FB")] PrefabInstantiate,
    }
  }
}
