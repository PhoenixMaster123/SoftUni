package DemoReflectionAndAnotation;

import java.lang.annotation.ElementType;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;
import java.lang.annotation.Target;

@Target(ElementType.TYPE) // Type ⇒ classes + interfaces
@Retention(RetentionPolicy.RUNTIME)
public @interface Company {
    String name() default "Default_Name";
}
