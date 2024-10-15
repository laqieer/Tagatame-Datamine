// Decompiled with JetBrains decompiler
// Type: SRPG.SameUnitWarningMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A55")]
  [AddComponentMenu("UI/SameUnitWarningMessage")]
  public class SameUnitWarningMessage : MonoBehaviour
  {
    [Token(Token = "0x400CE09")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button button;

    [Token(Token = "0x600C123")]
    [Address(RVA = "0x899770", Offset = "0x898570", VA = "0x10899770")]
    private void Start()
    {
    }

    [Token(Token = "0x600C124")]
    [Address(RVA = "0x8994F0", Offset = "0x8982F0", VA = "0x108994F0")]
    private void OnClick(GameObject go)
    {
    }

    [Token(Token = "0x600C125")]
    [Address(RVA = "0x8995A0", Offset = "0x8983A0", VA = "0x108995A0")]
    public static void SameUnitWarningMessageDialog(UnitData unit)
    {
    }

    [Token(Token = "0x600C126")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SameUnitWarningMessage()
    {
    }
  }
}
