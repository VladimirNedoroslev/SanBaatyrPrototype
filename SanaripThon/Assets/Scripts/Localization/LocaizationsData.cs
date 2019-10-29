using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LocaizationsData
{
    public static Dictionary<string, Dictionary<string, string>> CulturedData =
        new Dictionary<string, Dictionary<string, string>>()
        {
            {
                "ru", new Dictionary<string, string>()
                {
                    {"Menu.Title", "Санарип Баатыр"},
                    {"Menu.Start", "Начать"},
                    {"Menu.Quit", "Выйти"},
                    {"Menu.About", "О нас"},
                    {
                        "Introduction.PreambuleBody",
                        "Манас – величайший герой Кыргызов, вернулся домой после успешного похода. В поисках долгожданного отдыха герой засыпает в своей юрте…"
                    },
                    {"Introduction.PreambuleTitle", "Текст преамбулы"},
                    {"Button.Continue", "Далее…"},
                    {"Item.CloakTitle", "Плащ инкогнито "},
                    {"Item.BootsTitle ", "Оптоволоконные ботинки"},
                    {"Item.ShieldTitle", "Щит Карсепского "},
                    {"Item.CloakDesc", "Плащ инкогнито – поможет путнику скрыться от опасности "},
                    {"Item.BootsDesc ", "Летучие сапоги – доставят их носителя куда угодно за считанные секунды"},
                    {"Item.ShieldDesc", "Щит Карсепского - большая защита для больших людей"},
                    {
                        "Item.CloakResult",
                        "Успех! С твоей помощью Манас выбрался из коварного лабиринта – перед ним расстилается необозримая ширь (чего) путешествие домой только начинается…"
                    },
                    {
                        "Item.BootsResult ",
                        "Высокая скорость – это конечно хорошо, но от всех угроз убежать не получится…"
                    },
                    {"Item.ShieldResult", "Когда-то щиты были очень полезны, но это время давно прошло"},
                    {
                        "Dialog.dialog1",
                        "«Странное место… На мир духов совсем не похоже»\n«Небо здесь как будто отлито из свинца»\nПосле недолгих поисков Манас натыкается на маленькую дверцу и решает в нее войти. Перед взором героя появляется запутанный лабиринт. Выбора нет – нашему герою предстоит тяжелое испытание, помоги Манасу вернуться домой! В твоем распоряжении – один из трех магических артефактов, который поможет Манасу в пути."
                    },
                }
            },
            {
                "en", new Dictionary<string, string>()
                {
                    {"Menu.Title", "Sanarip Baatyr"},
                    {"Menu.Start", "Let's go"},
                    {"Menu.Quit", "Quit"},
                    {"Menu.About", "About us"},
                    {
                        "Introduction.PreambuleBody",
                        "Manas - greatest hero of Kyrgyz people, came home after successful campaign. In search of long awaited location, our hero goes to sleep in his own yourt..."
                    },
                    {"Introduction.PreambuleTitle", "Preambule"},
                    {"Button.Continue", "Continue..."},
                    {"Item.CloakTitle", "Incognito cloak"},
                    {"Item.BootsTitle ", "Fiberoptic shoes"},
                    {"Item.ShieldTitle", "Kapsersky shield"},
                    {"Item.CloakDesc", "Incognito cloak - will help stanger to hide from danger"},
                    {"Item.BootsDesc ", "Flying boots - will deliver you in any place during just seconds"},
                    {"Item.ShieldDesc", "Kapsersky shield - BIG armor for a BIG GUY"},
                    {"Item.CloakResult", "ssss"},
                    {"Item.BootsResult ", "ssss"},
                    {"Item.ShieldResult", "ssss"},
                    {
                        "Dialog.dialog1",
                        "Strange place... This place doesn't look like spirit world. The sky seems casted from lead"
                    },

                }
            },
            {
                "kg", new Dictionary<string, string>()
                {
                    {"Menu.Title", "Санарип Баатыр"},
                    {"Menu.Start", "Оюнбаштоо"},
                    {"Menu.Quit", "Чыгуу"},
                    {"Menu.About", "Биз жөнүндө"},
                    {
                        "Introduction.PreambuleBody",
                        "Манас - Кыргызстандын ээн зоор киши, уйго чон согушту утум келгенден кийин, озунун бозуйунда уктап калат..."
                    },
                    {"Introduction.PreambuleTitle", "Преамбул"},
                    {"Button.Continue", "Андан ары…"},
                    {"Item.CloakTitle", "Инкогнито сырт кийим"},
                    {"Item.BootsTitle ", "Була-оптикалык өтүктөр"},
                    {"Item.ShieldTitle", "Карсепскийдин калканы"},
                    {"Item.CloakDesc", "Инкогнитолук плащ"},
                    {"Item.BootsDesc ", "Учкан буткийим - сени ар жерге секундада жонотоп берет"},
                    {"Item.ShieldDesc", "Карсперскийдин shield"},
                    {"Item.CloakResult", "ssss"},
                    {"Item.BootsResult ", "ssss"},
                    {"Item.ShieldResult", "ssss"},
                    {
                        "Dialog.dialog1",
                        "ssss"
                    },
                }
            }
        };
}
