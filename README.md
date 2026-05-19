			CREATE DATABASE IF NOT EXISTS `JuegoEducativo` 
			DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
			USE `JuegoEducativo`;
			
			CREATE TABLE IF NOT EXISTS `USUARIO` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `nombre` VARCHAR(50) NOT NULL,
			  `clave` VARCHAR(50) NOT NULL,
			  `rol` VARCHAR(20) NOT NULL, 
			  PRIMARY KEY (`id`)
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			CREATE TABLE IF NOT EXISTS `MODULO` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `nombreEs` VARCHAR(100) NOT NULL,
			  `nombreEn` VARCHAR(100) NOT NULL,
			  `descripcion` VARCHAR(500) NOT NULL,
			  PRIMARY KEY (`id`)
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			CREATE TABLE IF NOT EXISTS `PREGUNTA` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `idModulo` INT(11) NOT NULL,
			  `preguntaEs` TEXT NOT NULL,
			  `preguntaEn` TEXT NOT NULL,
			  `imagenRuta` VARCHAR(500) NOT NULL,
			  PRIMARY KEY (`id`),
			  FOREIGN KEY (`idModulo`) REFERENCES `MODULO`(`id`) ON DELETE CASCADE
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			CREATE TABLE IF NOT EXISTS `OPCION` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `idPregunta` INT(11) NOT NULL,
			  `textoES` VARCHAR(500) NOT NULL,
			  `textoEn` VARCHAR(500) NOT NULL,
			  `esCorrecta` TINYINT(1) NOT NULL, 
			  PRIMARY KEY (`id`),
			  FOREIGN KEY (`idPregunta`) REFERENCES `PREGUNTA`(`id`) ON DELETE CASCADE
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			CREATE TABLE IF NOT EXISTS `PUNTUACION` (
			  `id` INT(11) NOT NULL AUTO_INCREMENT,
			  `idUsuario` INT(11) NOT NULL,
			  `idModulo` INT(11) NOT NULL,
			  `puntos` INT(11) NOT NULL,
			  PRIMARY KEY (`id`),
			  FOREIGN KEY (`idUsuario`) REFERENCES `USUARIO`(`id`) ON DELETE CASCADE,
			  FOREIGN KEY (`idModulo`) REFERENCES `MODULO`(`id`) ON DELETE CASCADE
			) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
			
			INSERT IGNORE INTO MODULO (id, nombreEs, nombreEn, descripcion) VALUES 
			(1, 'Arquitectura del computador', 'Computer Architecture', 'Hardware y componentes'),
			(2, 'Antropología', 'Anthropology', 'Estudio del ser humano'),
			(3, 'Cálculo', 'Calculus', 'Derivadas e integrales'),
			(4, 'Deporte y primeros auxilios', 'Sports and First Aid', 'Actividad física y conocimientos básicos de emergencia');
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿Cuál es el componente de la Unidad Central de Procesamiento (CPU) encargado de realizar operaciones matemáticas y comparaciones lógicas?', 'Which component of the Central Processing Unit (CPU) is responsible for performing mathematical operations and logical comparisons?', '');
			SET @id_p1 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p1, 'Unidad Aritmético Lógica (ALU)', 'Arithmetic Logic Unit (ALU)', 1), (@id_p1, 'Unidad de Control (UC)', 'Control Unit (CU)', 0), (@id_p1, 'Registro de Instrucción (IR)', 'Instruction Register (IR)', 0), (@id_p1, 'Memoria Caché', 'Cache Memory', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿Cuál es el componente de hardware diseñado para resguardar de forma permanente el sistema operativo y tus archivos personales?', 'Which hardware component is designed to permanently safeguard the operating system and your personal files?', '');
			SET @id_p2 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p2, 'Unidad de Disco Duro (HDD) / Unidad de Estado Sólido (SSD)', 'Hard Disk Drive (HDD) / Solid State Drive (SSD)', 1), (@id_p2, 'Memoria RAM', 'RAM Memory', 0), (@id_p2, 'Memoria Caché L1', 'L1 Cache Memory', 0), (@id_p2, 'Registro de Estado', 'Status Register', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿Dentro de la jerarquía de memoria, cuál de las siguientes opciones es la más rápida pero suele tener menor capacidad de almacenamiento?', 'Within the memory hierarchy, which of the following options is the fastest but usually has the lowest storage capacity?', '');
			SET @id_p3 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p3, 'Memoria Caché', 'Cache Memory', 1), (@id_p3, 'Memoria ROM', 'ROM Memory', 0), (@id_p3, 'Memoria RAM', 'RAM Memory', 0), (@id_p3, 'Disco Duro (HDD/SSD)', 'Hard Drive (HDD/SSD)', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, 'En el sistema de numeración binario utilizado por los computadores, ¿cuál es el valor decimal equivalente del número binario 1011?', 'In the binary numbering system used by computers, what is the equivalent decimal value of the binary number 1011?', '');
			SET @id_p4 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p4, '13', '13', 0), (@id_p4, '11', '11', 1), (@id_p4, '9', '9', 0), (@id_p4, '7', '7', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿Qué carácter alfanumérico representa al número decimal 15 dentro del sistema numérico hexadecimal?', 'Which alphanumeric character represents the decimal number 15 within the hexadecimal number system?', '');
			SET @id_p5 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p5, 'A', 'A', 0), (@id_p5, 'G', 'G', 0), (@id_p5, 'F', 'F', 1), (@id_p5, 'E', 'E', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿Qué es un "bit" en el contexto de los sistemas de numeración y la arquitectura del computador?', 'What is a "bit" in the context of numbering systems and computer architecture?', '');
			SET @id_p6 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p6, 'Un programa del sistema operativo encargado de borrar archivos temporales.', 'An operating system program responsible for deleting temporary files.', 0), (@id_p6, 'La unidad mínima de información que puede representar un 0 o un 1.', 'The minimum unit of information that can represent a 0 or a 1.', 1), (@id_p6, 'Un componente físico del procesador que realiza multiplicaciones.', 'A physical component of the processor that performs multiplications.', 0), (@id_p6, 'Un cable de cobre de alta velocidad para conectar la pantalla.', 'A high-speed copper cable to connect the screen.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿Cuál de los siguientes componentes se clasifica exclusivamente como un periférico de Entrada (E) de datos?', 'Which of the following components is classified exclusively as an Input (I) data peripheral?', '');
			SET @id_p7 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p7, 'Impresora', 'Printer', 0), (@id_p7, 'Altavoces (Cornetas)', 'Speakers', 0), (@id_p7, 'Monitor estándar', 'Standard monitor', 0), (@id_p7, 'Teclado', 'Keyboard', 1);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿Qué le sucede a la información guardada en la memoria RAM cuando el computador se apaga por completo?', 'What happens to the information stored in the RAM memory when the computer is completely turned off?', '');
			SET @id_p8 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p8, 'Se almacena de forma segura dentro del procesador principal.', 'It is securely stored inside the main processor.', 0), (@id_p8, 'Se transfiere automáticamente a una base de datos en la nube.', 'It is automatically transferred to a cloud database.', 0), (@id_p8, 'Se borra por completo debido al carácter volátil de esta memoria.', 'It is completely erased due to the volatile nature of this memory.', 1), (@id_p8, 'Permanece intacta y disponible para el próximo encendido.', 'It remains intact and available for the next power-on.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿A la Unidad Central de Procesamiento (CPU) se le conoce frecuentemente de forma metafórica como:', 'The Central Processing Unit (CPU) is frequently referred to metaphorically as:', '');
			SET @id_p9 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p9, 'El esqueleto metálico del chasis.', 'The metal skeleton of the chassis.', 0), (@id_p9, 'El regulador de voltaje de la fuente de poder.', 'The voltage regulator of the power supply.', 0), (@id_p9, 'El cerebro del computador.', 'The brain of the computer.', 1), (@id_p9, 'El almacén de archivos a largo plazo.', 'The long-term file store.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (1, '¿Cuáles son los únicos dígitos permitidos para representar información en el sistema numérico binario?', 'What are the only digits allowed to represent information in the binary number system?', '');
			SET @id_p10 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_p10, 'Los números impares del 1 al 9.', 'Odd numbers from 1 to 9.', 0), (@id_p10, 'Las letras de la A a la F.', 'Letters from A to F.', 0), (@id_p10, 'Los números del 0 al 9.', 'Numbers from 0 to 9.', 0), (@id_p10, 'Los números 0 y 1.', 'The numbers 0 and 1.', 1);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, '¿Cuál es la diferencia fundamental entre el proceso de hominización y el de humanización?', 'What is the fundamental difference between the process of hominization and humanization?', '');
			SET @id_a1 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a1, 'La hominización es un cambio netamente cultural y la humanización es un proceso puramente biológico.', 'Hominization is a purely cultural change and humanization is a purely biological process.', 0), (@id_a1, 'La hominización abarca la evolución biológica y física de la especie, mientras que la humanización se centra en el desarrollo cultural, simbólico y técnico.', 'Hominization covers the biological and physical evolution of the species, while humanization focuses on cultural, symbolic, and technical development.', 1), (@id_a1, 'Ambos procesos ocurren de forma aislada en épocas totalmente distintas sin llegar a cruzarse en la evolución.', 'Both processes occur in isolation during totally different eras without ever intersecting in evolution.', 0), (@id_a1, 'La humanización es exclusiva del Homo sapiens y la hominización pertenece únicamente a los primates no humanos.', 'Humanization is exclusive to Homo sapiens and hominization belongs uniquely to non-human primates.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, 'Al definir el objeto de estudio de la antropología filosófica, ¿qué la diferencia principalmente de la antropología científica o biológica?', 'When defining the object of study of philosophical anthropology, what mainly differentiates it from scientific or biological anthropology?', '');
			SET @id_a2 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a2, 'La filosófica busca comprender las causas últimas y la esencia integral del ser humano, mientras que la científica se limita a lo fenoménico, medible y empírico.', 'Philosophical anthropology seeks to understand the ultimate causes and integral essence of the human being, while scientific anthropology limits itself to the phenomenal, measurable, and empirical.', 1), (@id_a2, 'La filosófica solo se encarga del estudio del alma abstracta y la científica se enfoca únicamente en la estructura ósea.', 'Philosophical anthropology only deals with the study of the abstract soul and scientific anthropology focuses solely on bone structure.', 0), (@id_a2, 'La antropología filosófica no utiliza ningún tipo de razonamiento lógico o crítico en sus conclusiones.', 'Philosophical anthropology does not use any type of logical or critical reasoning in its conclusions.', 0), (@id_a2, 'La antropología científica descarta por completo la existencia de la cultura en las sociedades humanas.', 'Scientific anthropology completely discards the existence of culture in human societies.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, 'Si la antropología sostiene que el hombre es un "ser cultural por naturaleza", ¿cómo se explica esta aparente contradicción?', 'If anthropology maintains that man is a "cultural being by nature", how is this apparent contradiction explained?', '');
			SET @id_a3 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a3, 'Significa que la biología genética determina por completo qué tipo de manifestaciones culturales adoptará cada comunidad.', 'It means that genetic biology completely determines what kind of cultural manifestations each community will adopt.', 0), (@id_a3, 'Expresa que el ser humano nace biológicamente incompleto y requiere de la cultura (lenguaje, herramientas, sociedad) para poder realizarse y sobrevivir.', 'It expresses that the human being is born biologically incomplete and requires culture (language, tools, society) to survive and fulfill themselves.', 1), (@id_a3, 'Indica que la naturaleza animal y la cultura social son opuestas, por lo que el hombre debe elegir renunciar a una de ellas.', 'It indicates that animal nature and social culture are opposites, so man must choose to renounce one of them.', 0), (@id_a3, 'Significa que la cultura es un instinto genético e idéntico que se activa de la misma forma en todas las poblaciones del mundo.', 'It means that culture is a genetic and identical instinct that is activated in the same way across all world populations.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, 'En el método etnográfico, ¿por qué la "observación participante" representa una complejidad metodológica inicial?', 'In the ethnographic method, why does "participant observation" represent an initial methodological complexity?', '');
			SET @id_a4 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a4, 'Porque obliga al investigador a modificar activamente las leyes jurídicas del grupo social que está estudiando.', 'Because it forces the researcher to actively modify the legal laws of the social group under study.', 0), (@id_a4, 'Porque requiere equilibrar la distancia objetiva necesaria para el análisis científico con la inmersión subjetiva dentro de la comunidad.', 'Because it requires balancing the objective distance necessary for scientific analysis with subjective immersion within the community.', 1), (@id_a4, 'Porque prohíbe terminantemente que el antropólogo entable conversaciones directas con los miembros del grupo estudiado.', 'Because it strictly forbids the anthropologist from engaging in direct conversations with members of the studied group.', 0), (@id_a4, 'Porque es un procedimiento que solo se puede realizar de forma remota mediante herramientas virtuales.', 'Because it is a procedure that can only be carried out remotely using virtual tools.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, 'Desde la perspectiva de la antropología de la muerte, ¿cuál es el enfoque principal al estudiar este fenómeno?', 'From the perspective of the anthropology of death, what is the main focus when studying this phenomenon?', '');
			SET @id_a5 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a5, 'El análisis clínico del cese de las funciones vitales y la descomposición orgánica del cuerpo.', 'The clinical analysis of the cessation of vital functions and the organic decomposition of the body.', 0), (@id_a5, 'El estudio de cómo la conciencia de la finitud configura las estructuras de sentido, los rituales y la cosmovisión de una cultura.', 'The study of how the awareness of finitude shapes the structures of meaning, rituals, and worldview of a culture.', 1), (@id_a5, 'La búsqueda tecnológica y experimental de mecanismos para prolongar la vida biológica indefinidamente.', 'The technological and experimental search for mechanisms to prolong biological life indefinitely.', 0), (@id_a5, 'El registro de las tasas de mortalidad y su impacto en el censo de una región.', 'The recording of mortality rates and their impact on the census of a region.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, 'En el campo de la antropología tecnológica (tecnoantropología), ¿cuál es el núcleo del análisis al estudiar la relación entre el ser humano y los sistemas artificiales?', 'In the field of technological anthropology (techno-anthropology), what is the core of the analysis when studying the relationship between human beings and artificial systems?', '');
			SET @id_a6 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a6, 'El diseño técnico y la optimización del código fuente para mejorar el rendimiento de los equipos informáticos.', 'The technical design and optimization of source code to improve the performance of computer equipment.', 0), (@id_a6, 'Comprender cómo las herramientas y tecnologías no son simples objetos neutrales, sino agentes simbólicos que reconfiguran la cultura, la mente y la propia condición humana.', 'Understanding how tools and technologies are not simple neutral objects, but symbolic agents that reconfigure culture, the mind, and the human condition itself.', 1), (@id_a6, 'Demostrar que el desarrollo de software elimina por completo la necesidad de mantener estructuras sociales tradicionales.', 'Demonstrating that software development completely eliminates the need to maintain traditional social structures.', 0), (@id_a6, 'Rastrear de forma aislada la evolución cronológica de las máquinas sin vincularlas a las prácticas socioculturales de los usuarios.', 'Tracking the chronological evolution of machines in isolation without linking them to the sociocultural practices of the users.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, 'Al abordar la antropología política, ¿qué noción suele causar confusión sobre el ejercicio del poder?', 'When approaching political anthropology, what notion often causes confusion about the exercise of power?', '');
			SET @id_a7 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a7, 'Suponer que las estructuras de poder y regulación política existen exclusivamente en las sociedades que poseen un Estado formal e instituciones escritas.', 'Supposing that power structures and political regulation exist exclusively in societies that possess a formal State and written institutions.', 1), (@id_a7, 'Reconocer que todas las culturas, tengan o no un Estado centralizado, poseen mecanismos de control, ideología y organización colectiva.', 'Recognizing that all cultures, whether or not they have a centralized State, possess mechanisms of control, ideology, and collective organization.', 0), (@id_a7, 'Considerar que la política es una categoría universal ligada directamente a la toma de decisiones comunitarias.', 'Considering that politics is a universal category directly linked to community decision-making.', 0), (@id_a7, 'Afirmar que los conflictos ideológicos tienen una manifestación en la organización del espacio público.', 'Affirming that ideological conflicts have a manifestation in the organization of public space.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, '¿Cuál es una fuente de confusión habitual al estudiar la antropología económica en sociedades con lógicas distintas a la occidental?', 'What is a common source of confusion when studying economic anthropology in societies with logics different from the Western one?', '');
			SET @id_a8 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a8, 'Reducir el concepto de economía únicamente a la maximización de ganancias monetarias dentro de un mercado regulado por precios.', 'Reducing the concept of economics solely to the maximization of monetary profits within a price-regulated market.', 1), (@id_a8, 'Sostener que los procesos de producción y distribución de bienes materiales ocurren en todas las sociedades conocidas.', 'Maintaining that the processes of production and distribution of material goods occur in all known societies.', 0), (@id_a8, 'Asumir que el intercambio de recursos escasos tiene implicaciones sociales que van más allá del valor material del objeto.', 'Assuming that the exchange of scarce resources has social implications that go beyond the material value of the object.', 0), (@id_a8, 'Comprender que los sistemas basados en la reciprocidad y el don cumplen una función de cohesión comunitaria.', 'Understanding that systems based on reciprocity and the gift fulfill a function of community cohesion.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, 'Cuando la antropología filosófica analiza el "pensamiento y la trascendencia humana", ¿qué distinción es crucial para evitar equívocos?', 'When philosophical anthropology analyzes "human thought and transcendence", what distinction is crucial to avoid misunderstandings?', '');
			SET @id_a9 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a9, 'No limitar la trascendencia a lo religioso, sino entenderla como la capacidad humana de superar la inmediatez biológica mediante el arte, la ética o la filosofía.', 'Not limiting transcendence to the religious dimension, but understanding it as the human capacity to overcome biological immediacy through art, ethics, or philosophy.', 1), (@id_a9, 'Asumir que el pensamiento racional es un reflejo mecánico e idéntico al procesamiento de algoritmos en un sistema informático básico.', 'Assuming that rational thought is a mechanical reflection identical to algorithm processing in a basic computer system.', 0), (@id_a9, 'Negar cualquier vinculación entre la base neurobiológica del cerebro y el desarrollo de ideas abstractas complejas.', 'Denying any link between the neurobiological base of the brain and the development of complex abstract ideas.', 0), (@id_a9, 'Considerar la trascendencia como una propiedad física cuantificable mediante metodologías de laboratorio.', 'Considering transcendence as a physical property quantifiable through laboratory methodologies.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (2, 'Dentro del estudio de la Antropología de la Cultura Venezolana, ¿qué enfoque conceptual suele generar interpretaciones confusas sobre la identidad?', 'Within the study of the Anthropology of Venezuelan Culture, what conceptual approach usually generates confusing interpretations about identity?', '');
			SET @id_a10 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_a10, 'Abordar la identidad como un tejido dinámico, heterogéneo y en constante reinterpretación sincrética.', 'Approaching identity as a dynamic, heterogeneous fabric under constant syncretic reinterpretation.', 0), (@id_a10, 'Analizar la cultura como un conjunto estático, puro e inalterable que debe permanecer idéntico a sus raíces del pasado para ser legítimo.', 'Analyzing culture as a static, pure, and unalterable set that must remain identical to its roots from the past to be legitimate.', 1), (@id_a10, 'Investigar los procesos de resistencia y adaptación social reflejados en las expresiones populares urbanas y rurales.', 'Investigating the processes of social resistance and adaptation reflected in urban and rural popular expressions.', 0), (@id_a10, 'Estudiar la confluencia de distintas vertientes históricas y étnicas en el desarrollo de las tradiciones locales.', 'Studying the confluence of different historical and ethnic strands in the development of local traditions.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, '¿Cuál es el dominio de la función f(x) = 1 / √(x - 3)?', 'What is the domain of the function f(x) = 1 / √(x - 3)?', '');
			SET @id_c1 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c1, '(3, ∞)', '(3, ∞)', 1), (@id_c1, '[3, ∞)', '[3, ∞)', 0), (@id_c1, 'ℝ \\ {3}', 'ℝ \\ {3}', 0), (@id_c1, '(-∞, 3)', '(-∞, 3)', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, 'Evalúa el siguiente límite: lim x → 2 (x² - 4) / (x - 2)', 'Evaluate the following limit: lim x → 2 (x² - 4) / (x - 2)', '');
			SET @id_c2 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c2, '4', '4', 1), (@id_c2, '0', '0', 0), (@id_c2, 'No existe', 'Does not exist', 0), (@id_c2, '2', '2', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, '¿Cuál es la derivada de la función f(x) = 3x⁴ - 5x + 2?', 'What is the derivative of the function f(x) = 3x⁴ - 5x + 2?', '');
			SET @id_c3 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c3, '12x³ - 5', '12x³ - 5', 1), (@id_c3, '12x³ - 5x', '12x³ - 5x', 0), (@id_c3, '3x³ - 5', '3x³ - 5', 0), (@id_c3, '12x⁴ - 5', '12x⁴ - 5', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, 'Si una función f(x) es discontinua en x = c, ¿qué se puede afirmar sobre su derivabilidad en ese mismo punto?', 'If a function f(x) is discontinuous at x = c, what can be said about its differentiability at that same point?', '');
			SET @id_c4 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c4, 'Definitivamente no es derivable en x = c.', 'It is definitively not differentiable at x = c.', 1), (@id_c4, 'Podría ser derivable si las pendientes por la izquierda y derecha coinciden.', 'It could be differentiable if the slopes from the left and right match.', 0), (@id_c4, 'Es derivable solo si la discontinuidad es evitable.', 'It is differentiable only if the discontinuity is removable.', 0), (@id_c4, 'Siempre es derivable en ese punto.', 'It is always differentiable at that point.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, 'Determina el límite al infinito: lim x → ∞ (5x³ - 2x + 1) / (2x³ + 4x²)', 'Determine the limit at infinity: lim x → ∞ (5x³ - 2x + 1) / (2x³ + 4x²)', '');
			SET @id_c5 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c5, '5/2', '5/2', 1), (@id_c5, '∞', '∞', 0), (@id_c5, '0', '0', 0), (@id_c5, '1/4', '1/4', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, 'Utilizando la regla de la cadena, ¿cuál es la derivada de f(x) = sin(x²)?', 'Using the chain rule, what is the derivative of f(x) = sin(x²)?', '');
			SET @id_c6 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c6, '2x cos(x²)', '2x cos(x²)', 1), (@id_c6, 'cos(x²)', 'cos(x²)', 0), (@id_c6, '2x sin(x²)', '2x sin(x²)', 0), (@id_c6, 'cos(2x)', 'cos(2x)', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, '¿Qué representa geométricamente la derivada de una función en un punto dado?', 'What does the derivative of a function at a given point geometrically represent?', '');
			SET @id_c7 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c7, 'La pendiente de la recta tangente a la curva en ese punto.', 'The slope of the tangent line to the curve at that point.', 1), (@id_c7, 'El área bajo la curva desde el origen hasta ese punto.', 'The area under the curve from the origin to that point.', 0), (@id_c7, 'La ecuación de una recta secante que corta a la curva en dos puntos.', 'The equation of a secant line cutting the curve at two points.', 0), (@id_c7, 'El valor máximo que puede alcanzar la función.', 'The maximum value the function can achieve.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, 'Cuál es el valor del límite fundamental lim x → 0 sin(x) / x?', 'What is the value of the fundamental trigonometric limit lim x → 0 sin(x) / x?', '');
			SET @id_c8 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c8, '1', '1', 1), (@id_c8, '0', '0', 0), (@id_c8, 'No existe', 'Does not exist', 0), (@id_c8, '∞', '∞', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, 'Dada la función f(x) = e³ˣ, ¿cuál es su segunda derivada, f''(x)?', 'Given the function f(x) = e³ˣ, what is its second derivative, f''(x)?', '');
			SET @id_c9 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c9, '9e³ˣ', '9e³ˣ', 1), (@id_c9, '3e³ˣ', '3e³ˣ', 0), (@id_c9, '6e³ˣ', '6e³ˣ', 0), (@id_c9, 'e³ˣ', 'e³ˣ', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (3, '¿Para qué valores de x la función f(x) = x² - 4x + 5 tiene un punto crítico (donde su primera derivada es igual a cero)?', 'For what value of x does the function f(x) = x² - 4x + 5 have a critical point (where its first derivative equals zero)?', '');
			SET @id_c10 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_c10, 'x = 2', 'x = 2', 1), (@id_c10, 'x = 4', 'x = 4', 0), (@id_c10, 'x = 0', 'x = 0', 0), (@id_c10, 'x = 5', 'x = 5', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, 'En el voleibol, ¿en qué sentido rotan los jugadores en la cancha cuando su equipo recupera el derecho al saque?', 'In volleyball, in which direction do players rotate on the court when their team wins the right to serve?', '');
			SET @id_d1 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d1, 'En el sentido de las agujas del reloj', 'Clockwise', 1), (@id_d1, 'Rotan de manera libre según la estrategia del entrenador', 'They rotate freely according to the coach\'s strategy', 0), (@id_d1, 'No rotan, solo cambia el jugador que realiza el saque', 'They do not rotate, only the player who serves changes', 0), (@id_d1, 'En sentido contrario a las agujas del reloj', 'Counter-clockwise', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, '¿Cuál es la altura oficial de la red en el voleibol de sala para la categoría masculina absoluta?', 'What is the official height of the net in indoor volleyball for the men\'s senior category?', '');
			SET @id_d2 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d2, '2,24 metros', '2.24 meters', 0), (@id_d2, '2,43 metros', '2.43 meters', 1), (@id_d2, '2,35 metros', '2.35 meters', 0), (@id_d2, '2,50 metros', '2.50 meters', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, 'En el fútbol, ¿cuándo se considera que un jugador se encuentra en una posición de fuera de juego (offside) activa?', 'In soccer, when is a player considered to be in an active offside position?', '');
			SET @id_d3 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d3, 'Cuando recibe el balón directamente de un saque de banda cobrado por su propio compañero.', 'When they receive the ball directly from a throw-in taken by their own teammate.', 0), (@id_d3, 'Cuando está exactamente en la misma línea que el último defensor adversario.', 'When they are exactly on the same line as the last opposing defender.', 0), (@id_d3, 'Cuando está más cerca de la línea de meta contraria que el balón y el penúltimo adversario en el momento del pase e interviene en la jugada.', 'When they are closer to the opponent\'s goal line than both the ball and the second-last opponent at the moment the pass is made and they become involved in the play.', 1), (@id_d3, 'Cuando se encuentra en su propia mitad del terreno de juego al momento de salir el pase.', 'When they are in their own half of the field of play at the moment the pass is made.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, '¿Cuánto dura oficialmente un partido de fútbol profesional en el tiempo reglamentario regular?', 'How long does a professional soccer match officially last in regular regulation time?', '');
			SET @id_d4 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d4, '80 minutos, divididos en dos tiempos de 40 minutos.', '80 minutes, divided into two 40-minute halves.', 0), (@id_d4, '100 minutos, divididos en dos tiempos de 50 minutos.', '100 minutes, divided into two 50-minute halves.', 0), (@id_d4, '90 minutos, divididos en dos tiempos de 45 minutos.', '90 minutes, divided into two 45-minute halves.', 1), (@id_d4, '60 minutos, divididos en cuatro cuartos de 15 minutos.', '60 minutes, divided into four 15-minute quarters.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, 'Al aplicar la Reanimación Cardiopulmonar (RCP) básica en un adulto, ¿cuál es la relación recomendada entre compresiones torácicas y ventilaciones?', 'When performing basic Cardiopulmonary Resuscitation (CPR) on an adult, what is the recommended ratio between chest compressions and ventilations?', '');
			SET @id_d5 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d5, '15 compresiones seguidas de 2 ventilaciones', '15 compressions followed by 2 ventilations', 0), (@id_d5, '30 compresiones seguidas de 2 ventilaciones', '30 compressions followed by 2 ventilations', 1), (@id_d5, '50 compresiones seguidas de 5 ventilaciones', '50 compressions followed by 5 ventilations', 0), (@id_d5, '5 compresiones seguidas de 1 ventilación', '5 compressions followed by 1 ventilation', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, '¿Cuál es la primera acción recomendada ante una quemadura térmica leve (de primer grado) en el entorno doméstico?', 'What is the recommended first action for a minor thermal burn (first-degree) in a household environment?', '');
			SET @id_d6 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d6, 'Colocar hielo directamente sobre la lesión para detener el ardor.', 'Place ice directly on the injury to stop the burning sensation.', 0), (@id_d6, 'Refrescar la zona afectada con agua corriente templada o fresca durante varios minutos.', 'Cool the affected area with cool or lukewarm running water for several minutes.', 1), (@id_d6, 'Romper las posibles ampollas con una aguja esterilizada.', 'Pop any possible blisters with a sterilized needle.', 0), (@id_d6, 'Aplicar de inmediato una capa gruesa de pasta de dientes o mantequilla.', 'Immediately apply a thick layer of toothpaste or butter.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, 'Ante la sospecha de una fractura ósea en una extremidad debido a un golpe fuerte, ¿cuál es el principio básico de primeros auxilios?', 'If a bone fracture in a limb is suspected due to a heavy blow, what is the basic principle of first aid?', '');
			SET @id_d7 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d7, 'Vendar fuertemente la zona con máxima presión para obligar al hueso a unirse.', 'Bandage the area tightly with maximum pressure to force the bone together.', 0), (@id_d7, 'Tratar de jalar la extremidad para alinear el hueso antes de que se enfríe.', 'Try to pull the limb to align the bone before it cools down.', 0), (@id_d7, 'Inmovilizar la articulación superior e inferior a la lesión en la posición encontrada.', 'Immobilize the joint above and below the injury in the position it was found.', 1), (@id_d7, 'Realizar un masaje profundo con pomadas calientes para activar la circulación de la zona.', 'Perform a deep massage with hot ointments to activate circulation in the area.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, '¿Cómo se denominan a las posiciones de los tres jugadores que se ubican cerca de la red y tienen la función principal de bloquear y rematar?', 'What are the positions of the three players who stand near the net and whose main function is to block and spike/attack called?', '');
			SET @id_d8 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d8, 'Jugadores Zagueros (Posiciones 1, 6 y 5)', 'Back-row players (Positions 1, 6, and 5)', 0), (@id_d8, 'Jugadores Delanteros (Posiciones 2, 3 y 4)', 'Front-row players (Positions 2, 3, and 4)', 1), (@id_d8, 'Líberos de red', 'Net liberos', 0), (@id_d8, 'Colocadores de apoyo', 'Support setters', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, 'Durante una acción de juego, ¿cuál de las siguientes situaciones se considera una falta reglamentaria ("infracción") al contactar el balón?', 'During a game action, which of the following situations is considered a regulatory fault ("infraction") when contacting the ball?', '');
			SET @id_d9 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d9, 'Golpear el balón con el pie o con cualquier parte de las piernas de forma limpia.', 'Hitting the ball cleanly with the foot or any part of the legs.', 0), (@id_d9, 'Que el balón toque dos partes distintas del cuerpo de un mismo jugador de forma simultánea durante la defensa de un remate potente.', 'The ball touching two different parts of a player\'s body simultaneously during the defense of a powerful spike.', 0), (@id_d9, 'Retener, empujar o lanzar el balón con las manos en lugar de golpearlo limpiamente (Falta de "retención" o "llevada").', 'Catching, pushing, or throwing the ball with the hands instead of hitting it cleanly (Catch/Carried ball fault).', 1), (@id_d9, 'Golpear el balón con los antebrazos unidos teniendo los dedos entrelazados.', 'Hitting the ball with the forearms together while having the fingers interlaced.', 0);
			
			INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) VALUES (4, 'Al realizar el saque o servicio, ¿qué línea del campo no puede pisar ni tocar el jugador antes o durante el momento del golpeo al balón?', 'When serving, which court line can a player NOT step on or touch before or during the moment of hitting the ball?', '');
			SET @id_d10 = LAST_INSERT_ID();
			INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@id_d10, 'La línea central que divide ambos campos por debajo de la red.', 'The center line that divides both courts underneath the net.', 0), (@id_d10, 'La línea de ataque (línea de los 3 metros).', 'The attack line (3-meter line).', 0), (@id_d10, 'La línea de fondo (línea final que delimita el extremo de la cancha).', 'The endline (the baseline that delimits the boundary of the court).', 1), (@id_d10, 'Las líneas laterales exclusivamente.', 'The sidelines exclusively.', 0);
