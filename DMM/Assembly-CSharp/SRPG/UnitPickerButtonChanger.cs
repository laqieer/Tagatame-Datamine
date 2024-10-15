// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPickerButtonChanger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CD7")]
  [AddComponentMenu("UI/UnitPickerButtonChanger")]
  public class UnitPickerButtonChanger : MonoBehaviour
  {
    [Token(Token = "0x400DEDA")]
    [FieldOffset(Offset = "0xC")]
    [CustomField("ウィンド", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("ウィンド")]
    public GameObject m_Root;
    [Token(Token = "0x400DEDB")]
    [FieldOffset(Offset = "0x10")]
    [CustomField("OFF", CustomFieldAttribute.Type.UISprite)]
    [CustomGroup("差し替えボタン画像")]
    public Sprite m_ImageDefault;
    [Token(Token = "0x400DEDC")]
    [FieldOffset(Offset = "0x14")]
    [CustomField("ON", CustomFieldAttribute.Type.UISprite)]
    [CustomGroup("差し替えボタン画像")]
    public Sprite m_ImageOn;
    [Token(Token = "0x400DEDD")]
    [FieldOffset(Offset = "0x18")]
    [CustomField("イメージ", CustomFieldAttribute.Type.UIImage)]
    [CustomGroup("オブジェクト")]
    public Image m_Image;
    [Token(Token = "0x400DEDE")]
    [FieldOffset(Offset = "0x1C")]
    [CustomGroup("オブジェクト")]
    [CustomField("テキスト", CustomFieldAttribute.Type.UIText)]
    public Text m_Text;
    [Token(Token = "0x400DEDF")]
    [FieldOffset(Offset = "0x20")]
    private UnitListWindow m_Window;
    [Token(Token = "0x400DEE0")]
    [FieldOffset(Offset = "0x24")]
    private UnitListSortWindow.SelectType m_Sort;

    [Token(Token = "0x600D097")]
    [Address(RVA = "0x9BA6C0", Offset = "0x9B94C0", VA = "0x109BA6C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D098")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600D099")]
    [Address(RVA = "0x9BA750", Offset = "0x9B9550", VA = "0x109BA750")]
    private void Update()
    {
    }

    [Token(Token = "0x600D09A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600D09B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600D09C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitPickerButtonChanger()
    {
    }
  }
}
