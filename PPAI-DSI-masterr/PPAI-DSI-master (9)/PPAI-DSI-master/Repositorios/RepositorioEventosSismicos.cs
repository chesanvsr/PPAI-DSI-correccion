using PPAI_DSI.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Repositorios
{
    public class RepositorioEventosSismicos
    {
        private List<EventoSismico> eventos;

        public RepositorioEventosSismicos()
        {
            // Seed de eventos hard-codeados:
            eventos = new List<EventoSismico>
            {
                // 1. Sismo moderado en Córdoba
                new EventoSismico(
                    DateTime.Parse("2025-05-23 14:00"),
                    DateTime.Parse("2025-05-23 14:20"),
                    -31.4201, -64.1888, -31.4235, -64.1905, 4.7,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-05-23 14:00"),
                            DateTime.Parse("2025-05-23 14:10"),
                            new Empleado("Ana","Rodriguez"),
                            new Estado("Evento Sismico","Autodetectado")
                        ),
                        new CambioEstado(
                            DateTime.Parse("2025-05-23 14:10"),
                            DateTime.Parse("2025-05-23 14:15"),
                            new Empleado("Ana","Rodriguez"),
                            new Estado("Evento Sismico","PendienteRevision")
                        ),
                        new CambioEstado(
                            DateTime.Parse("2025-05-23 14:15"),
                            null,
                            new Empleado("Ana","Rodriguez"),
                            new Estado("Evento Sismico","Bloqueado")
                        )
                    },
                    new Alcance("Detectado en estaciones regionales, no sentido por la población", "Regional"),
                    new OrigenDeGeneracion("Falla tectónica cordobesa", "Tectónico"),
                    new Clasificacion(0, 18, "Superficial"),
                    new List<SerieTemporal>
                    {
                        new SerieTemporal(
                            "Cordoba1",
                            DateTime.Parse("2025-05-23 14:00"),
                            DateTime.Parse("2025-05-23 14:05"),
                            1,
                            new List<MuestraSismica>
                            {
                                // Muestra 1:
                                new MuestraSismica(
                                    DateTime.Parse("2025-05-23 14:00"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            7.00,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 7.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            10.00,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 10.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.70,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.70)
                                        )
                                    }
                                ),
                                // Muestra 2:
                                new MuestraSismica(
                                    DateTime.Parse("2025-05-23 14:01"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            7.02,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 7.02)
                                        ),
                                        new DetalleMuestraSismica(
                                            10.00,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 10.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.69,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.69)
                                        )
                                    }
                                )
                            },
                            // Estación para Córdoba
                            new EstacionSismologica(
                                1,
                                "CertCordoba-001",
                                DateTime.Parse("2024-12-01"),
                                -31.4201f,
                                -64.1888f,
                                "Cordoba1",
                                1001
                            )
                        )
                    },
                    new Estado("Evento Sismico", "Bloqueado")
                ),

                // 2. Sismo superficial en San Juan (ahora con 5 series temporales)
                new EventoSismico(
                    DateTime.Parse("2025-04-12 09:45"),
                    DateTime.Parse("2025-04-12 10:05"),
                    -31.5375, -68.5364, -31.5400, -68.5300, 5.2,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-04-12 09:45"),
                            null,
                            new Empleado("Juan","Pérez"),
                            new Estado("Evento Sismico","PendienteRevision")
                        ),
                    },
                    new Alcance("Percibido en zonas urbanas de San Juan", "Local"),
                    new OrigenDeGeneracion("Zona sísmica precordillerana", "Tectónico"),
                    new Clasificacion(0, 20, "Superficial"),
                    new List<SerieTemporal>
                    {
                        // SerieTemporal 1 (estación 2) con 2 muestras
                        new SerieTemporal(
                            "SanJuan1",
                            DateTime.Parse("2025-04-12 09:45"),
                            DateTime.Parse("2025-04-12 09:55"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-04-12 09:46"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.50,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.50)
                                        ),
                                        new DetalleMuestraSismica(
                                            9.80,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 9.80)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.80,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.80)
                                        )
                                    }
                                ),
                                new MuestraSismica(
                                    DateTime.Parse("2025-04-12 09:47"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.55,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.55)
                                        ),
                                        new DetalleMuestraSismica(
                                            9.85,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 9.85)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.79,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.79)
                                        )
                                    }
                                )
                            },
                            new EstacionSismologica(
                                2,
                                "CertSanJuan-001",
                                DateTime.Parse("2024-11-15"),
                                -31.5375f,
                                -68.5364f,
                                "SanJuan Estación 1",
                                2002
                            )
                        ),

                        // SerieTemporal 2 (estación 3) con 1 muestra
                        new SerieTemporal(
                            "SanJuan2",
                            DateTime.Parse("2025-04-12 09:48"),
                            DateTime.Parse("2025-04-12 09:56"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-04-12 09:49"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.60,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.60)
                                        ),
                                        new DetalleMuestraSismica(
                                            9.90,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 9.90)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.79,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.79)
                                        )
                                    }
                                )
                            },
                            new EstacionSismologica(
                                3,
                                "CertSanJuan-002",
                                DateTime.Parse("2024-11-20"),
                                -31.5400f,
                                -68.5300f,
                                "SanJuan Estación 2",
                                2003
                            )
                        ),

                        // SerieTemporal 3 (estación 2) con 1 muestra
                        new SerieTemporal(
                            "SanJuan3",
                            DateTime.Parse("2025-04-12 09:50"),
                            DateTime.Parse("2025-04-12 09:59"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-04-12 09:51"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.45,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.45)
                                        ),
                                        new DetalleMuestraSismica(
                                            9.75,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 9.75)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.81,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.81)
                                        )
                                    }
                                )
                            },
                            new EstacionSismologica(
                                2,
                                "CertSanJuan-001",
                                DateTime.Parse("2024-11-15"),
                                -31.5375f,
                                -68.5364f,
                                "SanJuan Estación 1",
                                2002
                            )
                        ),

                        // SerieTemporal 4 (estación 3) con 2 muestras
                        new SerieTemporal(
                            "SanJuan4",
                            DateTime.Parse("2025-04-12 09:52"),
                            DateTime.Parse("2025-04-12 10:00"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-04-12 09:53"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.70,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.70)
                                        ),
                                        new DetalleMuestraSismica(
                                            10.00,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 10.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.78,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.78)
                                        )
                                    }
                                ),
                                new MuestraSismica(
                                    DateTime.Parse("2025-04-12 09:54"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.75,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.75)
                                        ),
                                        new DetalleMuestraSismica(
                                            10.05,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 10.05)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.77,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.77)
                                        )
                                    }
                                )
                            },
                            new EstacionSismologica(
                                3,
                                "CertSanJuan-002",
                                DateTime.Parse("2024-11-20"),
                                -31.5400f,
                                -68.5300f,
                                "SanJuan Estación 2",
                                2003
                            )
                        ),

                        // SerieTemporal 5 (estación 2) con 1 muestra
                        new SerieTemporal(
                            "SanJuan5",
                            DateTime.Parse("2025-04-12 09:56"),
                            DateTime.Parse("2025-04-12 10:05"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-04-12 09:57"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.65,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.65)
                                        ),
                                        new DetalleMuestraSismica(
                                            9.95,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 9.95)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.80,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.80)
                                        )
                                    }
                                )
                            },
                            new EstacionSismologica(
                                2,
                                "CertSanJuan-001",
                                DateTime.Parse("2024-11-15"),
                                -31.5375f,
                                -68.5364f,
                                "SanJuan Estación 1",
                                2002
                            )
                        )
                    },
                    new Estado("Evento Sismico", "PendienteRevision")
                ),

                // 3. Sismo intermedio en Salta
                new EventoSismico(
                    DateTime.Parse("2025-03-01 06:20"),
                    DateTime.Parse("2025-03-01 06:40"),
                    -24.7821, -65.4231, -24.7840, -65.4200, 6.1,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-03-01 06:20"),
                            DateTime.Parse("2025-03-01 06:25"),
                            new Empleado("Lucía","Mendoza"),
                            new Estado("Evento Sismico","Autodetectado")
                        ),
                        new CambioEstado(
                            DateTime.Parse("2025-03-01 06:25"),
                            null,
                            new Empleado("Lucía","Mendoza"),
                            new Estado("Evento Sismico","PendienteRevision")
                        )
                    },
                    new Alcance("Percibido en todo el NOA, informes en Jujuy y Tucumán", "Regional"),
                    new OrigenDeGeneracion("Zona de subducción andina", "Subducción"),
                    new Clasificacion(70, 80, "Intermedio"),
                    new List<SerieTemporal>
                    {
                        new SerieTemporal(
                            "Salta1",
                            DateTime.Parse("2025-03-01 06:21"),
                            DateTime.Parse("2025-03-01 06:30"),
                            1,
                            new List<MuestraSismica>
                            {
                                // Muestra 1:
                                new MuestraSismica(
                                    DateTime.Parse("2025-03-01 06:22"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            8.00,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 8.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            12.00,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 12.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.60,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.60)
                                        )
                                    }
                                ),
                                // Muestra 2:
                                new MuestraSismica(
                                    DateTime.Parse("2025-03-01 06:24"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            8.10,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 8.10)
                                        ),
                                        new DetalleMuestraSismica(
                                            12.10,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 12.10)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.58,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.58)
                                        )
                                    }
                                )
                            },
                            // Estación para Salta
                            new EstacionSismologica(
                                4,
                                "CertSalta-001",
                                DateTime.Parse("2024-10-30"),
                                -24.7821f,
                                -65.4231f,
                                "Salta Estación 1",
                                3004
                            )
                        )
                    },
                    new Estado("Evento Sismico", "PendienteRevision")
                ),

                // 4. Sismo profundo en Mendoza
                new EventoSismico(
                    DateTime.Parse("2025-02-15 03:30"),
                    DateTime.Parse("2025-02-15 03:55"),
                    -32.8908, -68.8272, -32.8920, -68.8250, 5.9,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-02-15 03:30"),
                            null,
                            new Empleado("María","González"),
                            new Estado("Evento Sismico","PendienteRevision")
                        )
                    },
                    new Alcance("Percibido levemente en zonas altas de Mendoza", "Regional"),
                    new OrigenDeGeneracion("Deslizamiento de placas", "Tectónico"),
                    new Clasificacion(150, 170, "Profundo"),
                    new List<SerieTemporal>
                    {
                        new SerieTemporal(
                            "Mendoza1",
                            DateTime.Parse("2025-02-15 03:31"),
                            DateTime.Parse("2025-02-15 03:40"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-02-15 03:32"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            5.50,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 5.50)
                                        ),
                                        new DetalleMuestraSismica(
                                            8.50,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 8.50)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.50,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.50)
                                        )
                                    }
                                )
                            },
                            // Estación para Mendoza 1
                            new EstacionSismologica(
                                5,
                                "CertMendoza-001",
                                DateTime.Parse("2024-09-15"),
                                -32.8908f,
                                -68.8272f,
                                "Mendoza Estación 1",
                                4005
                            )
                        ),
                        new SerieTemporal(
                            "Mendoza2",
                            DateTime.Parse("2025-02-15 03:35"),
                            DateTime.Parse("2025-02-15 03:42"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-02-15 03:36"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            5.40,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 5.40)
                                        ),
                                        new DetalleMuestraSismica(
                                            8.60,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 8.60)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.48,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.48)
                                        )
                                    }
                                )
                            },
                            // Estación para Mendoza 2
                            new EstacionSismologica(
                                6,
                                "CertMendoza-002",
                                DateTime.Parse("2024-09-20"),
                                -32.8920f,
                                -68.8250f,
                                "Mendoza Estación 2",
                                4006
                            )
                        )
                    },
                    new Estado("Evento Sismico", "PendienteRevision")
                ),

                // 5. Evento detectado pero sin revisión en Tierra del Fuego
                new EventoSismico(
                    DateTime.Parse("2025-01-05 22:10"),
                    DateTime.Parse("2025-01-05 22:35"),
                    -54.8019, -68.3029, -54.8000, -68.3000, 3.8,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-01-05 22:10"),
                            null,
                            new Empleado("Carlos","López"),
                            new Estado("Evento Sismico","FinalizadoSinRevision")
                        )
                    },
                    new Alcance("Solo registrado por estaciones automáticas", "Local"),
                    new OrigenDeGeneracion("Actividad volcánica leve", "Volcánico"),
                    new Clasificacion(0, 12, "Superficial"),
                    new List<SerieTemporal>
                    {
                        new SerieTemporal(
                            "Ushuaia1",
                            DateTime.Parse("2025-01-05 22:11"),
                            DateTime.Parse("2025-01-05 22:20"),
                            1,
                            new List<MuestraSismica>
                            {
                                // Muestra 1:
                                new MuestraSismica(
                                    DateTime.Parse("2025-01-05 22:12"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            3.00,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 3.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            5.00,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 5.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.30,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.30)
                                        )
                                    }
                                ),
                                // Muestra 2:
                                new MuestraSismica(
                                    DateTime.Parse("2025-01-05 22:13"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            3.10,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 3.10)
                                        ),
                                        new DetalleMuestraSismica(
                                            5.10,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 5.10)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.31,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.31)
                                        )
                                    }
                                )
                            },
                            // Estación para Ushuaia
                            new EstacionSismologica(
                                7,
                                "CertUshuaia-001",
                                DateTime.Parse("2024-08-05"),
                                -54.8019f,
                                -68.3029f,
                                "Ushuaia Estación 1",
                                5007
                            )
                        )
                    },
                    new Estado("Evento Sismico", "FinalizadoSinRevision")
                ),

                // 6. Sismo moderado en Jujuy
                new EventoSismico(
                    DateTime.Parse("2025-05-20 17:00"),
                    DateTime.Parse("2025-05-20 17:25"),
                    -24.1858, -65.2995, -24.1880, -65.2950, 4.8,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-05-20 17:00"),
                            null,
                            new Empleado("Natalia","Fernández"),
                            new Estado("Evento Sismico","PendienteRevision")
                        )
                    },
                    new Alcance("Percibido en San Salvador de Jujuy", "Local"),
                    new OrigenDeGeneracion("Falla de los Andes Centrales", "Tectónico"),
                    new Clasificacion(15, 25, "Superficial"),
                    new List<SerieTemporal>
                    {
                        new SerieTemporal(
                            "Jujuy1",
                            DateTime.Parse("2025-05-20 17:01"),
                            DateTime.Parse("2025-05-20 17:10"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-05-20 17:02"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.20,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.20)
                                        ),
                                        new DetalleMuestraSismica(
                                            11.00,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 11.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.56,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.56)
                                        )
                                    }
                                )
                            },
                            // Estación para Jujuy 1
                            new EstacionSismologica(
                                8,
                                "CertJujuy-001",
                                DateTime.Parse("2024-07-10"),
                                -24.1858f,
                                -65.2995f,
                                "Jujuy Estación 1",
                                6008
                            )
                        ),
                        new SerieTemporal(
                            "Jujuy2",
                            DateTime.Parse("2025-05-20 17:05"),
                            DateTime.Parse("2025-05-20 17:15"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-05-20 17:06"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            6.30,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 6.30)
                                        ),
                                        new DetalleMuestraSismica(
                                            11.10,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 11.10)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.55,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.55)
                                        )
                                    }
                                )
                            },
                            // Estación para Jujuy 2
                            new EstacionSismologica(
                                9,
                                "CertJujuy-002",
                                DateTime.Parse("2024-07-15"),
                                -24.1880f,
                                -65.2950f,
                                "Jujuy Estación 2",
                                6009
                            )
                        )
                    },
                    new Estado("Evento Sismico", "PendienteRevision")
                ),

                // 7. Microevento en La Rioja
                new EventoSismico(
                    DateTime.Parse("2025-04-10 08:00"),
                    DateTime.Parse("2025-04-10 08:25"),
                    -29.4110, -66.8509, -29.4120, -66.8490, 2.9,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-04-10 08:00"),
                            null,
                            new Empleado("Mario","Silva"),
                            new Estado("Evento Sismico","PendienteRevision")
                        )
                    },
                    new Alcance("Solo detectado instrumentalmente", "Local"),
                    new OrigenDeGeneracion("Reacomodamiento interno", "Inducido"),
                    new Clasificacion(5, 15, "Superficial"),
                    new List<SerieTemporal>
                    {
                        new SerieTemporal(
                            "LaRioja1",
                            DateTime.Parse("2025-04-10 08:01"),
                            DateTime.Parse("2025-04-10 08:10"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-04-10 08:02"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            2.00,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 2.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            4.00,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 4.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.20,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.20)
                                        )
                                    }
                                )
                            },
                            // Estación para La Rioja
                            new EstacionSismologica(
                                10,
                                "CertLaRioja-001",
                                DateTime.Parse("2024-06-20"),
                                -29.4110f,
                                -66.8509f,
                                "LaRioja Estación 1",
                                70010
                            )
                        )
                    },
                    new Estado("Evento Sismico", "PendienteRevision")
                ),

                // 8. Sismo leve en Catamarca
                new EventoSismico(
                    DateTime.Parse("2025-03-18 11:10"),
                    DateTime.Parse("2025-03-18 11:30"),
                    -28.4696, -65.7795, -28.4700, -65.7780, 3.5,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-03-18 11:10"),
                            null,
                            new Empleado("Sofía","Ramírez"),
                            new Estado("Evento Sismico","PendienteRevision")
                        )
                    },
                    new Alcance("Percibido levemente por la población", "Local"),
                    new OrigenDeGeneracion("Zona de transición andina", "Tectónico"),
                    new Clasificacion(10, 22, "Superficial"),
                    new List<SerieTemporal>
                    {
                        new SerieTemporal(
                            "Catamarca1",
                            DateTime.Parse("2025-03-18 11:11"),
                            DateTime.Parse("2025-03-18 11:18"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-03-18 11:12"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            4.00,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 4.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            7.00,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 7.00)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.40,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.40)
                                        )
                                    }
                                )
                            },
                            // Estación para Catamarca
                            new EstacionSismologica(
                                11,
                                "CertCatamarca-001",
                                DateTime.Parse("2024-05-10"),
                                -28.4696f,
                                -65.7795f,
                                "Catamarca Estación 1",
                                80011
                            )
                        )
                    },
                    new Estado("Evento Sismico", "PendienteRevision")
                ),

                // 9. Sismo leve en Buenos Aires
                new EventoSismico(
                    DateTime.Parse("2025-05-01 13:00"),
                    DateTime.Parse("2025-05-01 13:30"),
                    -34.6037, -58.3816, -34.6050, -58.3800, 2.5,
                    new List<CambioEstado>
                    {
                        new CambioEstado(
                            DateTime.Parse("2025-05-01 13:00"),
                            null,
                            new Empleado("Luciano","Martínez"),
                            new Estado("Evento Sismico","PendienteRevision")
                        )
                    },
                    new Alcance("Detectado instrumentalmente", "Local"),
                    new OrigenDeGeneracion("Fractura menor en llanura pampeana", "Inducido"),
                    new Clasificacion(5, 10, "Superficial"),
                    new List<SerieTemporal>
                    {
                        new SerieTemporal(
                            "BuenosAires1",
                            DateTime.Parse("2025-05-01 13:01"),
                            DateTime.Parse("2025-05-01 13:10"),
                            1,
                            new List<MuestraSismica>
                            {
                                new MuestraSismica(
                                    DateTime.Parse("2025-05-01 13:02"),
                                    new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica(
                                            3.50,
                                            new TipoDeDato("Velocidad de Onda", "Km/seg", 3.50)
                                        ),
                                        new DetalleMuestraSismica(
                                            6.50,
                                            new TipoDeDato("Frecuencia de Onda", "Hz", 6.50)
                                        ),
                                        new DetalleMuestraSismica(
                                            0.35,
                                            new TipoDeDato("Longitud de Onda", "km/ciclo", 0.35)
                                        )
                                    }
                                )
                            },
                            // Estación para Buenos Aires
                            new EstacionSismologica(
                                12,
                                "CertBAires-001",
                                DateTime.Parse("2024-04-05"),
                                -34.6037f,
                                -58.3816f,
                                "BAires Estación 1",
                                90012
                            )
                        )
                    },
                    new Estado("Evento Sismico", "PendienteRevision")
                )

            };
        }

        public List<EventoSismico> ObtenerTodos()
        {
            return eventos;
        }
    }
}


