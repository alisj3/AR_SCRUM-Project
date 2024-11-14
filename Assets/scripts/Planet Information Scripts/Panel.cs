using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI panelTitle;

    [SerializeField]
    public TextMeshProUGUI panelInfo;

    public Dictionary<string, List<string>> solarSystemDescriptions = new Dictionary<string, List<string>>();

    [SerializeField]
    public GameObject panel;

    public Button nextButton;

    public Button closeButton;


    int nextDescription;


    void Start()
    {
        panel.SetActive(false);
        solarSystemDescriptions.Add("Sun", new List<string> 
        {
            "The Sun is a massive sphere of hot plasma at the center of our solar system, primarily composed of hydrogen and helium. Through nuclear fusion, it releases light and heat that are essential for life on Earth.",

            "As the heart of our solar system, the Sun drives Earth�s weather, ocean currents, and seasonal cycles. It holds over 99% of the total mass in the solar system, keeping planets, asteroids, and comets in orbit.",

            "With a surface temperature of around 5,500 degrees Celsius, the Sun�s energy shapes atmospheres and supports ecosystems across the planets. Its core is even hotter, reaching temperatures over 15 million degrees Celsius.",

        });
        solarSystemDescriptions.Add("Mercury", new List<string>
        {
            "Mercury is the smallest planet in our solar system and the closest to the Sun, orbiting at an average distance of 58 million kilometers. Its lack of atmosphere means it can't retain heat, leading to extreme temperature swings between scorching days and freezing nights.",

            "Mercury�s surface is heavily cratered, resembling our Moon, and is marked by vast plains and steep cliffs that stretch for hundreds of kilometers. With no moons or rings, Mercury has a sparse and desolate landscape shaped by frequent asteroid impacts over billions of years.",

            "A single day on Mercury, known as a 'sidereal day,' lasts about 59 Earth days. Its orbit around the Sun is fast, taking only 88 Earth days, making it the shortest year in the solar system. Its proximity to the Sun means it experiences intense solar radiation, complicating observations from Earth.",
        });

        solarSystemDescriptions.Add("Venus", new List<string>
        {
            "Venus, often called Earth's 'sister planet' due to its similar size and structure, is enveloped in a dense, toxic atmosphere primarily composed of carbon dioxide, with clouds of sulfuric acid. This thick atmosphere creates a runaway greenhouse effect, making Venus the hottest planet with surface temperatures around 465 degrees Celsius.",

            "The planet's surface is a harsh landscape of volcanic plains, rugged highlands, and large impact craters. Venus rotates slowly and in the opposite direction to most other planets, so the Sun rises in the west and sets in the east. Despite this slow rotation, intense winds in its upper atmosphere reach speeds of up to 360 kilometers per hour.",

            "A day on Venus is longer than its year, taking 243 Earth days to complete one rotation, while it orbits the Sun in 225 days. This slow rotation and dense atmosphere make Venus an enigmatic world with extreme conditions and weather patterns.",
        });

        solarSystemDescriptions.Add("Earth", new List<string>
        {
            "Earth is the only known planet to support diverse life, thanks to its ideal conditions, such as moderate temperatures, liquid water, and a protective atmosphere. About 71% of Earth's surface is covered by oceans, which help regulate temperature and weather patterns across the planet.",

            "Earth's atmosphere, mainly nitrogen and oxygen, shields life from harmful solar radiation and moderates surface temperatures. The planet has a magnetic field generated by its iron core, which deflects solar winds and cosmic rays, creating conditions necessary for sustaining life.",

            "Earth rotates once every 24 hours, creating day and night, and completes an orbit around the Sun every 365.25 days, giving us our seasons. Earth�s natural satellite, the Moon, stabilizes its tilt and influences tidal patterns, impacting life and climate over time.",
        });

        solarSystemDescriptions.Add("Mars", new List<string>
        {
            "Mars, known as the Red Planet, is characterized by its iron-rich surface that gives it a reddish appearance. Although its atmosphere is thin and mostly composed of carbon dioxide, Mars has seasonal patterns and polar ice caps made of frozen carbon dioxide and water.",

            "Mars hosts the largest volcano in the solar system, Olympus Mons, towering 22 kilometers high, and Valles Marineris, a canyon system stretching over 4,000 kilometers, showcasing the planet�s active geological past. Scientists believe Mars may have had liquid water on its surface in the distant past, hinting at the possibility of ancient life.",

            "A day on Mars is similar to Earth, lasting 24.6 hours, while a year takes 687 Earth days. Mars has two small, irregularly shaped moons, Phobos and Deimos, which may be captured asteroids from the asteroid belt. Mars remains a key focus in the search for past or present extraterrestrial life.",
        });

        solarSystemDescriptions.Add("Jupiter", new List<string>
        {
            "Jupiter is the giant of our solar system, over 11 times the diameter of Earth, and made primarily of hydrogen and helium. Its thick atmosphere contains ammonia crystals and water vapor, creating complex bands of clouds, storms, and striking colors.",

            "The Great Red Spot, a massive storm larger than Earth, has persisted for at least 400 years and is an iconic feature of Jupiter. The planet emits more heat than it receives from the Sun, believed to be due to slow gravitational contraction and internal heat release.",

            "Jupiter has a powerful magnetic field and at least 75 moons, including Ganymede, the largest moon in the solar system. The planet�s rapid rotation, completing a day in just under 10 hours, creates intense atmospheric dynamics and fascinating weather patterns.",
        });

        solarSystemDescriptions.Add("Saturn", new List<string>
        {
            "Saturn is known for its stunning ring system, composed of billions of ice and rock particles that orbit the planet in thin bands. Like Jupiter, Saturn is a gas giant made mostly of hydrogen and helium, with a distinct yellowish hue due to ammonia in its upper atmosphere.",

            "Saturn's rings span up to 282,000 kilometers in diameter but are only about 10 meters thick. The planet's density is so low that it would float in water, making it unique among the planets. Saturn also has hexagonal storms at its poles, adding to its unique appearance.",

            "With over 80 moons, Saturn�s largest moon, Titan, has lakes and rivers of liquid methane and a thick, nitrogen-rich atmosphere. Saturn takes about 29.5 Earth years to complete one orbit, experiencing long seasonal changes that vary over time.",
        });

        solarSystemDescriptions.Add("Uranus", new List<string>
        {
            "Uranus is an ice giant with a blue-green color due to methane in its atmosphere, which absorbs red light. The planet�s unique feature is its extreme axial tilt of 98 degrees, meaning it essentially rotates on its side, causing one pole to face the Sun for half of its 84-year orbit.",

            "Uranus�s atmosphere is composed of hydrogen, helium, and methane, with faint rings and 27 known moons. It experiences extreme seasonal variations due to its tilt, leading to unusual weather patterns, especially during the equinox when both poles experience direct sunlight.",

            "With a diameter about four times that of Earth, Uranus has a rocky core surrounded by a thick icy mantle. Its interior is composed of water, ammonia, and methane ices, giving it a more solid composition than Jupiter and Saturn.",
        });

        solarSystemDescriptions.Add("Neptune", new List<string>
        {
            "Neptune is the farthest planet from the Sun and an ice giant, similar in composition to Uranus but darker and more vivid blue. The methane in its atmosphere and an unknown atmospheric compound give Neptune its striking blue color, setting it apart from other planets.",

            "Neptune has some of the fastest winds in the solar system, reaching speeds of up to 2,100 kilometers per hour, which create massive storms such as the Great Dark Spot, observed by the Voyager 2 spacecraft in 1989. These violent storms are short-lived, forming and dissipating quickly in its dynamic atmosphere.",

            "Neptune has 14 known moons, with Triton being the largest. Triton is unique in that it orbits Neptune in the opposite direction of the planet's rotation, suggesting it may be a captured Kuiper Belt object. Neptune�s faint rings, composed of dust particles, reflect light and add to its mysterious beauty.",
        });


    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.CompareTag("Planet") || hit.collider.CompareTag("NextButton"))
                {
                    panel.SetActive(true);
                    nextDescription = 0;
                    panelTitle.text = hit.collider.gameObject.name;
                    panelInfo.text = solarSystemDescriptions[panelTitle.text][nextDescription];
                    nextButton.onClick.AddListener(nextDescriptopn);
                    closeButton.onClick.AddListener(closeOption);
                }
            }

        }
    }

    public void nextDescriptopn()
    {
        nextDescription = nextDescription + 1;
        if (nextDescription > 2)
        {
            nextDescription = 0;
            panelInfo.text = solarSystemDescriptions[panelTitle.text][nextDescription];
        }
        panelInfo.text = solarSystemDescriptions[panelTitle.text][nextDescription];
    }

    public void closeOption()
    {
        panel.SetActive(false);
    }
}