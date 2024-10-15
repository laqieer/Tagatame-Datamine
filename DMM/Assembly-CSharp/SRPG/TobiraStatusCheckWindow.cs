// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraStatusCheckWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B31")]
  [AddComponentMenu("UI/TobiraStatusCheckWindow")]
  public class TobiraStatusCheckWindow : MonoBehaviour
  {
    [Token(Token = "0x400D2E1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform m_TobiraStatusListItemRoot;
    [Token(Token = "0x400D2E2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private TobiraStatusListItem m_TobiraStatusListItemTemplate;

    [Token(Token = "0x600C5AC")]
    [Address(RVA = "0x8E3880", Offset = "0x8E2680", VA = "0x108E3880")]
    private void Start()
    {
    }

    [Token(Token = "0x600C5AD")]
    [Address(RVA = "0x8E3480", Offset = "0x8E2280", VA = "0x108E3480")]
    private void Setup(UnitData unit_data)
    {
    }

    [Token(Token = "0x600C5AE")]
    [Address(RVA = "0x8E33C0", Offset = "0x8E21C0", VA = "0x108E33C0")]
    private TobiraStatusListItem CreateListItem() => (TobiraStatusListItem) null;

    [Token(Token = "0x600C5AF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TobiraStatusCheckWindow()
    {
    }
  }
}
