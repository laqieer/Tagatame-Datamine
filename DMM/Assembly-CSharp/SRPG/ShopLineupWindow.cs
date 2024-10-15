// Decompiled with JetBrains decompiler
// Type: SRPG.ShopLineupWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AA5")]
  [AddComponentMenu("UI/ShopLineupWindow")]
  public class ShopLineupWindow : MonoBehaviour
  {
    [Token(Token = "0x400CFE0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400CFE1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text lineuplist;

    [Token(Token = "0x600C2B9")]
    [Address(RVA = "0x8AFF60", Offset = "0x8AED60", VA = "0x108AFF60")]
    private void Start()
    {
    }

    [Token(Token = "0x600C2BA")]
    [Address(RVA = "0x8AFCA0", Offset = "0x8AEAA0", VA = "0x108AFCA0")]
    public void SetItemInames(Json_ShopLineupItem[] lineups)
    {
    }

    [Token(Token = "0x600C2BB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopLineupWindow()
    {
    }
  }
}
