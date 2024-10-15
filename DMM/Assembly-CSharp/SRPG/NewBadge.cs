// Decompiled with JetBrains decompiler
// Type: SRPG.NewBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027BC")]
  [AddComponentMenu("UI/NewBadge")]
  public class NewBadge : MonoBehaviour
  {
    [Token(Token = "0x400BC20")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject BadgeObject;
    [Token(Token = "0x400BC21")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public NewBadgeType SelectBadgeType;

    [Token(Token = "0x600B277")]
    [Address(RVA = "0x7A7D70", Offset = "0x7A6B70", VA = "0x107A7D70")]
    private void Start()
    {
    }

    [Token(Token = "0x600B278")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B279")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NewBadge()
    {
    }
  }
}
